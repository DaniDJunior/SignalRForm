using Microsoft.AspNet.SignalR.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalRForm.Client
{
    public partial class Form1 : Form
    {
        private IHubProxy _hub;
        private HubConnection connection;
        private bool conectado = false;
        private string _messagem = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string url = @"http://localhost:61506//";
            connection = new HubConnection(url);
            _hub = connection.CreateHubProxy("mensagens");
            
            _hub.On("ConnectionSucess", x => ConnectionSucess(x));
            _hub.On("MessageError", x => MessageError(x));
            _hub.On("MessageEco", x => MessageEco(JsonConvert.DeserializeObject<Retorno>(x.ToString())));
            _hub.On("MessageReciever", x => MessageReciever(JsonConvert.DeserializeObject<Retorno>(x.ToString())));
            connection.Closed += () => { connection.Start().Wait(); };
            connection.ConnectionSlow += () => { Console.WriteLine("Conexão signalr lenta"); };
            connection.Start().Wait();
        }

        private void ConnectionSucess(string messagem)
        {
            conectado = true;
        }

        private void MessageError(string messagem)
        {
            MessageBox.Show(messagem);
        }

        private void MessageEco(Retorno messagem)
        {
            _messagem = "Message enviada para " + messagem.destino + "\r\n" + messagem.data + "\r\n" + messagem.messagem;
        }

        private void MessageReciever(Retorno messagem)
        {
            _messagem = "Message recebida de " + messagem.origem + "\r\n" + messagem.data + "\r\n" + messagem.messagem;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            _hub.Invoke("SendMessange", txtDestino.Text, txtMensagem.Text, txtEmail.Text).Wait();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            _hub.Invoke("CreateConnection", txtEmail.Text).Wait();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtEmail.Enabled = !conectado;
            btnConectar.Enabled = !conectado;
            btnEnviar.Enabled = conectado;
            txtDestino.Enabled = conectado;
            txtMensagem.Enabled = conectado;
            if(!string.IsNullOrEmpty(_messagem))
            {
                txtDados.Text += _messagem + "\r\n";
                _messagem = string.Empty;
            }
        }
    }

    public class Retorno
    {
        public string origem { get; set; }
        public string destino { get; set; }
        public string messagem { get; set; }
        public string data { get; set; }
    }
}
