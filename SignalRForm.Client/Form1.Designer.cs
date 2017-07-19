namespace SignalRForm.Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDados = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 25);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(357, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(375, 22);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtDestino
            // 
            this.txtDestino.Enabled = false;
            this.txtDestino.Location = new System.Drawing.Point(9, 281);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(438, 20);
            this.txtDestino.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino:";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Enabled = false;
            this.txtMensagem.Location = new System.Drawing.Point(9, 320);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(438, 60);
            this.txtMensagem.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mensagem:";
            // 
            // txtDados
            // 
            this.txtDados.Location = new System.Drawing.Point(12, 51);
            this.txtDados.Multiline = true;
            this.txtDados.Name = "txtDados";
            this.txtDados.ReadOnly = true;
            this.txtDados.Size = new System.Drawing.Size(438, 211);
            this.txtDados.TabIndex = 7;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Location = new System.Drawing.Point(372, 386);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 419);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtDados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDados;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Timer timer1;
    }
}

