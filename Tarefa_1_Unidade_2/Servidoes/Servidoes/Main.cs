using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace Servidoes
{
    public partial class Main : Form
    {
        private Server server;

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
            AlteraEstadoBotoes(false);
            server = new Server();
            var exercicioSelecionado = GbxEscolhaExercicio.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).TabIndex;
            var conectado = server.EsperaPorConexao();
            LblIpConectado.Text = conectado;
            var msgLida = server.LeDados();
            LblMsgRecebida.Text = msgLida;
            var msgEnviada = Questoes.TratarQuestao(exercicioSelecionado, msgLida);
            LblMsgEnviada.Text = msgEnviada;
            server.EnviaResposta(msgEnviada);
            server.EncerraConexao();
            AlteraEstadoBotoes(true);
        }

        private void AlteraEstadoBotoes(bool f)
        {
            GbxEscolhaExercicio.Enabled = f;
            BtEscuta.Enabled = f;
        }
    }
}