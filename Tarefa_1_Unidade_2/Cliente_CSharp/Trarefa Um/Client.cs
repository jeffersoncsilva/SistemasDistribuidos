using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Trarefa_Um
{
    internal class Client
    {
        private string nomeHost = "127.0.0.1";
        private int porta = 12345;

        private Socket socket;
        private IPAddress ipAdress;
        private NetworkStream stream;
        private StreamWriter writer;
        private StreamReader reader;

        public Client(string ip, string porta)
        {
            this.nomeHost = String.IsNullOrEmpty(ip) ? Padroes.IP_PADRAO : ip;
            this.porta = String.IsNullOrEmpty(porta) ? Padroes.PORTA_PADRAO : int.Parse(porta);
            
            CriaSocketConexao();
            ConectaAoServidor();
        }

        private void CriaSocketConexao()
        {
            this.ipAdress = IPAddress.Parse(this.nomeHost);
            this.socket = new Socket(this.ipAdress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }

        public bool ConectaAoServidor()
        {
            try
            {
                IPEndPoint ipendpoint = new IPEndPoint(ipAdress, this.porta);
                socket.Connect(ipendpoint);
              
                stream = new NetworkStream(socket);
                writer = new StreamWriter(stream);
                reader = new StreamReader(stream);
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            return true;
        }

        public string? EnviaDadosServidor(string msg)
        {
            try
            {
                writer.Write(msg);
                writer.Flush();
            }
            catch (SocketException e)
            {
                return $"Erro ao enviar dados ao servidor.\n{e.ToString()}";
            }
            try
            {
                return reader.ReadLine();
            }
            catch (SocketException ex)
            {
                return $"Erro ao receber dados ao servidor.\n{ex.ToString()}";
            }
        }

        public void EncerraConexao()
        {
            stream.Close();
            writer.Close();
            reader.Close();
            socket.Close();
        }
    }
}
