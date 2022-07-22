using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace Servidoes
{
    public partial class Main : Form
    {
        private Server? server;
      
        public Main()
        {
            InitializeComponent();
            // Pega o ip do usuario
            lblPorta.Text = $"Porta: {Padroes.PORTA_PADRAO}";
            lblIpServidor.Text = PegaIpMaquina();
            Padroes.FormataFormsIniciais(this, "Servidores");
            
        }

        private string PegaIpMaquina()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            var ip = host
                .AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
            return $"{ip}";
        }

        private void BtEscuta_Click(object sender, EventArgs e)
        {
            BtnIniciaServidor.Enabled = false;
            AtivarServidor();
            BtnIniciaServidor.Enabled = true;
        }

        private void AtivarServidor()
        {
            server = new Server();
            var conectado = server.EsperaPorConexao();
            LblIpConectado.Text = conectado;
            var msg = server.LeDados();
            LblMsgRecebida.Text = msg;
            var msgEnviada = Questoes.TratarQuestao(msg);
            LblMsgEnviada.Text = msgEnviada;
            msgEnviada += '\n';
            server.EnviaResposta(msgEnviada);
            server.EncerraConexao();
        }

        private void AlteraEstadoBotoes(bool f)
        {
            //GbxEscolhaExercicio.Enabled = f;
            BtnIniciaServidor.Enabled = f;
        }

    }
}