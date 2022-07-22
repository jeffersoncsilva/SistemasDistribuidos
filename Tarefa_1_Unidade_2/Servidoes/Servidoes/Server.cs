using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Servidoes
{
    public class Server
    {

        protected IPEndPoint ip;
        protected Socket socket;
        protected Socket client;
        protected NetworkStream stream;
        protected StreamReader reader;
        protected StreamWriter writer; 

        public Server()
        {
            ip = new IPEndPoint(IPAddress.Any, Padroes.PORTA_PADRAO);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        protected void CriaStream() => stream = new NetworkStream(client);

        public string EsperaPorConexao()
        {
            socket.Bind(this.ip);
            socket.Listen();
            this.client = socket.Accept();
            IPEndPoint clientip = (IPEndPoint)this.client.RemoteEndPoint;
            stream = new NetworkStream(this.client);
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);
            return $"IP:Porta {clientip.Address}:{clientip.Port}";
        }
        
        public string LeDados()
        {
            return reader.ReadLine();
        }

        public void EnviaResposta(string msg)
        {
            try
            {
                writer.Write(msg);
                writer.Flush();
            }catch(SocketException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void EncerraConexao()
        {
            writer.Close();
            reader.Close();
            stream.Close();
            client.Close();
            socket.Close();
        }
    }
}
