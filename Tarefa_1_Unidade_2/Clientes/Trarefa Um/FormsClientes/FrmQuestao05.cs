using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trarefa_Um.FormsClientes
{
    public partial class FrmQuestao05 : Form
    {
        private string ip, porta;
        private Client c;

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            BtnValidar.Enabled = false;
            this.c = new Client(this.ip, this.porta);
            var msg = TxbIdade.Text;
            if (string.IsNullOrWhiteSpace(msg) && double.TryParse(msg, out double res) && res >= 0)
                throw new DadosInvalidosException("Idade errada inserida.");
            var result = c.EnviaDadosServidor(msg);
            MessageBox.Show(result);
            TxbIdade.Text = "";
            BtnValidar.Enabled = true;
            c.EncerraConexao();
        }

        private void TxbIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public FrmQuestao05(string ip, string porta)
        {
            InitializeComponent();
            this.ip = ip;
            this.porta = porta;
            Padroes.FormataFormsIniciais(this, "Cliente - Questão 5");
        }
    }
}
