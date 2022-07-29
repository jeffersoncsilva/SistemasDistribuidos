using System.Net;
using System.Net.Sockets;

namespace Servidor_de_Regra_de_Negocio
{
    public class Connection 
    {
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;
        private IPEndPoint ip;
        private ClienteBancoDeDados client_bd;

        private Socket client;

        public Connection(Socket c, string ip_bd, int porta_bd)
        {
            this.client = c;
            this.ip = (IPEndPoint)client.RemoteEndPoint;
            stream = new NetworkStream(this.client);
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);
            client_bd = new ClienteBancoDeDados(ip_bd, porta_bd);
        }

        public void Run()
        {
            Console.WriteLine("Recebido conexão de: " + ip.Address);
            // Recebe: QUESTAO$OPERACAO$PARAMS_ADICIONAIS
            string str = reader.ReadLine();
            string[] strs = str.Split("$");
            int questao = int.Parse(strs[0]);
            int op = int.Parse(strs[1]);
            string res_busca_bd = client_bd.BuscarNoBancoDeDados(str);

        }
    }
}
