using Trarefa_Um.FormsClientes;

namespace Trarefa_Um   
{
    public partial class Main : Form
    {
        public const int PORTA = 26891;

        public Main()
        {
            InitializeComponent();
            Padroes.FormataFormsIniciais(this, "Clientes");
        }

        private void btnClienteQuestao01_Click(object sender, EventArgs e)
        {
            string ip = txbIpServidor.Text;
            string porta = txbPortaServidor.Text;
            Form questao01 = new FrmQuestao1(ip, porta);
            questao01.Show();
        }

        private void btnQuestao5_Click(object sender, EventArgs e)
        {
            Form frm = new FrmQuestao2(txbIpServidor.Text, txbPortaServidor.Text);
            frm.Show();
        }

        private void btnQuestao3_Click(object sender, EventArgs e)
        {
            var fr = new FrmQuestao3(txbIpServidor.Text, txbPortaServidor.Text);
            fr.Show();
        }

        private void BtnQuestao4_Click(object sender, EventArgs e)
        {
            var fr = new FrmQuestao4(txbIpServidor.Text, txbPortaServidor.Text);
            fr.Show();
        }

        private void BtnQuest5_Click(object sender, EventArgs e)
        {
            var ft = new FrmQuestao5(txbIpServidor.Text, txbPortaServidor.Text);
            ft.Show();
        }

        private void BtnQuestao6_Click(object sender, EventArgs e)
        {
            var fr = new FrmQuestao6(txbIpServidor.Text, txbPortaServidor.Text);
            fr.Show();
        }

        private void BtnQuestao7_Click(object sender, EventArgs e)
        {
            var q7 = new FrmQuestao7(txbIpServidor.Text, txbPortaServidor.Text);
            q7.Show();
        }

        private void BtnQuestao8_Click(object sender, EventArgs e)
        {
            var q8 = new FrmQuestao8(txbIpServidor.Text, txbPortaServidor.Text);
            q8.Show();
        }

        private void BtnQuestao9_Click(object sender, EventArgs e)
        {
            var q9 = new FrmQuestao9(txbIpServidor.Text, txbPortaServidor.Text);
            q9.Show();
        }
    }
}