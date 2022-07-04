using Bibliotecas;
using System.Net.Sockets;
using System.Text;

namespace Trarefa_Um.Clientes
{
    internal class ClienteQuestao02
    {
        private Client client;
        private string mensagem = "";

        public ClienteQuestao02(string ip, string porta, string nome, int sexo, int idade)
        {
            this.client = new Client(ip, porta);

            if (string.IsNullOrWhiteSpace(nome))
                throw new DadosInvalidosException("Nome invalido inserido.");
            if(sexo < 0 || sexo > 1)
                throw new DadosInvalidosException("Sexo invalido inserido.");
            if(idade < 0)
                throw new DadosInvalidosException("Idade invalida inserido.");
            this.mensagem = Padroes.GeraMensagem(new object[3] { nome, sexo, idade });
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
