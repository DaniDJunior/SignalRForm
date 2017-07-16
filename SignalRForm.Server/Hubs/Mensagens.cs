using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRForm.Server.Hubs
{
    [HubName("mensagens")]
    public class Mensagens : Hub
    {
        public void CreateConnection(string nome)
        {
            if (CacheHelper.Exists("Client_" + nome))
            {
                Clients.Caller.MessageError("Usuario já existe");
            }
            else
            {
                CacheHelper.Add<string>(Context.ConnectionId, "Client_" + nome);
                //Clients.Caller.ConnectionSucess("Chat conectado para " + nome);
                if (CacheHelper.Exists("Client"))
                {
                    CacheHelper.Add<string>(CacheHelper.Get<string>("Client") + "," + nome, "Client");
                }
                else
                {
                    CacheHelper.Add<string>(nome, "Client");
                }
                //Clients.All.MessageNewUser(CacheHelper.Get<string>("Client"));
            }
        }
    }
}