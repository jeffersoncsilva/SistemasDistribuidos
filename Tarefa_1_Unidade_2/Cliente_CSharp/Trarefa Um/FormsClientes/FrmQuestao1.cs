
namespace Trarefa_Um
{
    public partial class FrmQuestao1 : Form
    {
        private string ip, porta;
        public FrmQuestao1(string ip, string porta)
        {
            this.ip = ip;
            this.porta = porta;
            InitializeComponent();
            Padroes.FormataFormsIniciais(this, "Questao 01 - Cliente");            
        }

        private void txbSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txbNome.Text;
                int cargo = cmbCargo.SelectedIndex;
                string salario = txbSalario.Text;
                Client cl01 = new Client(this.ip, this.porta);
                string resultado = cl01.EnviaDadosServidor(Padroes.GeraMensagem(new object[] {1, nome, cargo, salario }));
                MessageBox.Show(resultado);
            }
            catch (DadosInvalidosException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
