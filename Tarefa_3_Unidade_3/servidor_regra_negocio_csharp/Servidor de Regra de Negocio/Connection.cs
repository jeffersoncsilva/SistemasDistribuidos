using System.Net;
using System.Net.Sockets;
using System.Text.Json;

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
            Console.WriteLine("Conectado com: " + ip.Address);
            try
            {
                string str = reader.ReadLine();
                Console.WriteLine("Solicitação recebida: {0}", str);
                string response = "Opção solicitada não foi reconhecida.\n";
                if (!String.IsNullOrWhiteSpace(str))
                {
                    switch (str)
                    {
                        case "BtnQuestao1":
                            response = RegraNegocio<Questao1>("1$1\n");
                            break;
                        case "BtnQuestao2":
                            response = RegraNegocio<Questao2>("2$1\n");
                            break;
                        case "BtnQuestao3":
                            response = RegraNegocio<Questao3>("3$1\n");
                            break;
                        case "BtnQuestao4":
                            response = RegraNegocio<Questao4>("4$1\n");
                            break;
                        case "BtnQuestao5":
                            response = RegraNegocio<Questao5>("5$1\n");
                            break;
                        case "BtnQuestao6":
                            response = RegraNegocio<Questao6>("6$1\n");
                            break;
                        case "BtnQuestao7":
                            response = RegraNegocio<Questao7>("7$1\n");
                            break;
                        case "BtnQuestao8":
                            response = RegraNegocio<Questao8>("8$1\n");
                            break;
                        case "BtnQuestao9":
                            Random r = new Random();
                            int i = r.Next(53);
                            response = RegraNegocio<Questao9>($"9$2${i}\n");
                            break;
                    }
                }
                Console.WriteLine("Dados processados. Enviando: ");
                Console.WriteLine(response);
                writer.WriteLine(response);
                writer.Flush();
                writer.Close();
                reader.Close();
                client.Close();
                client_bd.EncerraConexao();
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        private string RegraNegocio<T>(string path)
        {
            string resp = "\n";
            string dadosJson = client_bd.BuscarNoBancoDeDados(path);
            Console.WriteLine("-------\nDados recebidos do banco de dados: \n{0}\n-------\n", dadosJson);
            var questoes = JsonSerializer.Deserialize<List<T>>(dadosJson);
            List<string> res = new List<string>();
            foreach (var i in questoes)
            {
                var c = i as Questao;
                c.AplicarRegra();
                res.Add(c.ToString());
            }
            resp = JsonSerializer.Serialize<List<string>>(res);
            return resp;
        }
    }
}
