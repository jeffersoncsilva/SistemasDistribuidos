using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Interface_Cliente
{
    internal class Cliente
    {
        private string ip_serv;
        private int porta_serv;
        private Socket socket;
        private IPAddress ipAdress;

        private NetworkStream stream;
        private StreamWriter writer;
        private StreamReader reader;

        public Cliente(string ip_serv, int porta_serv)
        {
            this.ip_serv = ip_serv;
            this.porta_serv = porta_serv;
            try
            {
                this.ipAdress = IPAddress.Parse(this.ip_serv);
                this.socket = new Socket(this.ipAdress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipendpoint = new IPEndPoint(ipAdress, porta_serv);
                socket.Connect(ipendpoint);
                MessageBox.Show($"Conectado a: {ip_serv}:{porta_serv}.");
                stream = new NetworkStream(socket);
                writer = new StreamWriter(stream);
                reader = new StreamReader(stream);
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.ToString());
                throw new ErroConexaoException("Erro ao se conectar com o servidor.");
            }         
        }

        public string EnviaDadosServidor(string msg)
        {
            string res = "Erro ao enviar dados.";
            try
            {
                writer.WriteLine(msg);
                writer.Flush();
                res = reader.ReadLine();
                return res;
            }catch(SocketException e)
            {
                Console.WriteLine(e.ToString());
                throw new ErroConexaoException("Erro ao enviar ou receber os dados do servidor.");
            }
        }

        public void EncerrarConexao()
        {
            writer.Close();
            reader.Close();
            socket.Close();
        }
    }
}
