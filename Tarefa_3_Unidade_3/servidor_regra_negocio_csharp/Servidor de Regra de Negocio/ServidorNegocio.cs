using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Servidor_de_Regra_de_Negocio
{
    internal class ServidorNegocio
    {
        protected IPEndPoint ip;
        protected Socket socket;
        protected Socket client;
        private int porta_serv;

        public ServidorNegocio(int porta)
        {
            this.porta_serv = porta;
            ip = new IPEndPoint(IPAddress.Any, porta_serv);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void escuta()
        {
            socket.Bind(this.ip);
            socket.Listen();
            while (true)
            {
                this.client = socket.Accept();
                Console.WriteLine("Conectado");
                //Thread t = new Thread(new ThreadStart(new Connection(this.client, this.ip_bd, this.porta_bd).Run));
                //t.Start();
            }
        }
    }
}
