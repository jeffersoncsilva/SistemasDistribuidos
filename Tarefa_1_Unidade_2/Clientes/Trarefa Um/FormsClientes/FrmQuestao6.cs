namespace Trarefa_Um.FormsClientes
{
    public partial class FrmQuestao6 : Form
    {
        private string ip, porta;

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (DadosValidos())
            {
                BtnCalcular.Enabled = false;
                string nome = TxbNome.Text;
                string salario = TxbSalario.Text;
                string dependentes = TxbDependentes.Text;
                string nivel = GbNivel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

                var client = new Client(this.ip, this.porta);
                string msg = Padroes.GeraMensagem(new object[] {nome, salario, dependentes, nivel });
                var resp = client.EnviaDadosServidor(msg);
                MessageBox.Show(resp);
                BtnCalcular.Enabled = true;
            }
        }

        public FrmQuestao6(string ip, string porta)
        {
            InitializeComponent();
            this.ip = ip;
            this.porta = porta;
            Padroes.FormataFormsIniciais(this, "Cliente - Questão 06");
        }

        private bool DadosValidos()
        {
            if (string.IsNullOrWhiteSpace(TxbNome.Text))
            {
                MessageBox.Show("Nome invalido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxbDependentes.Text) && int.TryParse(TxbDependentes.Text, out int qtd) && qtd < 0)
            {
                MessageBox.Show("Quantidade de dependentes errada.");
                return false;
            }
            if(string.IsNullOrWhiteSpace(TxbSalario.Text) && double.TryParse(TxbSalario.Text, out double sal) && sal < 0)
            {
                MessageBox.Show("Salário errado informado.");
                return false;
            }
            if(!RbA.Checked && !RbB.Checked && !RbC.Checked && !RbD.Checked)
            {
                MessageBox.Show("Escolha um nível");
                return false;
            }
            return true;
        }
    }
}
