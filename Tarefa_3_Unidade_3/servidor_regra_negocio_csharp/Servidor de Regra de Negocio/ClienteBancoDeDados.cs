using System.Net;
using System.Net.Sockets;

namespace Servidor_de_Regra_de_Negocio
{
    public class ClienteBancoDeDados
    {
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;
        private IPAddress ip_bd_addres;
        private IPEndPoint ip;

        private int porta_bd;
        private string ip_serv_bd;
        private string params_connection;

        private Socket client_bd;

        public ClienteBancoDeDados(string ip_bd, int port_bd)
        {
            this.ip_serv_bd = ip_bd;
            this.porta_bd = port_bd;
            ip_bd_addres = IPAddress.Parse(ip_serv_bd);
            client_bd = new Socket(ip_bd_addres.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ip_ep_bd = new IPEndPoint(ip_bd_addres, porta_bd);
            client_bd.Connect(ip_ep_bd);
            stream = new NetworkStream(client_bd);
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);
        }

        public string BuscarNoBancoDeDados(string busca)
        {
            string res = "";
            if (!client_bd.Connected)
                client_bd.Connect(new IPEndPoint(ip_bd_addres, porta_bd));
            try
            {
                writer.WriteLine(busca);
                writer.Flush();
                res = reader.ReadLine();               
            }
            catch (SocketException se)
            {
                Console.WriteLine("Erro na comunicação com o servidor de dados.");
                Console.WriteLine(se.ToString());
            }

            return res;
        }

        public void EncerraConexao()
        {
            writer.Close();
            reader.Close();
            client_bd.Close();
        }
    }
}
