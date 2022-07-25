namespace Trarefa_Um.FormsClientes
{
    public partial class FrmQuestao3 : Form
    {
        private string ip, porta;
        public FrmQuestao3(string ip, string porta)
        {
            InitializeComponent();
            Padroes.FormataFormsIniciais(this, "Cliente - Questão 3");
            this.ip = ip;
            this.porta = porta;
        }

        private void txbNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            btnEnviar.Enabled = false;
            var client = new Client(this.ip, this.porta);
            var resultado = client.EnviaDadosServidor(Padroes.GeraMensagem(new object[] {3, txbNota1.Text, txbNota2.Text, txbNota3.Text}));
            MessageBox.Show(resultado);
            client.EncerraConexao();
            btnEnviar.Enabled = true;
        }
    }
}
