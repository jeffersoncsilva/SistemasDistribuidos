using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Bibliotecas;

namespace Trarefa_Um.Clientes
{
    internal class ClienteQuestao01
    {
        private string mensagem = "";
        private Client client;
        public ClienteQuestao01(string ip, string porta, string nome, int cargo, string salario)
        {
            this.client = new Client(ip, porta);
            string n = String.IsNullOrEmpty(nome) ? throw new DadosInvalidosException("Dados de nome, cargo ou salário invalidos informados.") : nome;
            int c = cargo < 0 || cargo > 1 ? throw new DadosInvalidosException("Dados de nome, cargo ou salário invalidos informados.") : cargo;
            double salari = 0;
            if(string.IsNullOrWhiteSpace(salario) || !double.TryParse(salario, out salari))
            {
                throw new DadosInvalidosException("Dados de nome, cargo ou salário invalidos informados.");
            }
            this.mensagem = Padroes.GeraMensagem(new object[] {nome, cargo, salario});
        }

        public string EnviaDadosServidor()
        {
            return this.client.EnviaDadosServidor(this.mensagem);
        }

        public void EncerraConexao()
        {
            this.client.EncerraConexao();
        }
    }
}
