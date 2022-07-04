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
    public partial class FrmQuestao7 : Form
    {
        private string ip, porta;

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            if (DadosValidos())
            {
                BtnVerificar.Enabled = false;
                string idade = TxbIdade.Text;
                string tempo = TxbTempo.Text;
                var c = new Client(this.ip, this.porta);
                var res = c.EnviaDadosServidor(Padroes.GeraMensagem(new object[] { idade, tempo }));
                MessageBox.Show(res);
                c.EncerraConexao();
                BtnVerificar.Enabled = true;
            }
        }

        public FrmQuestao7(string ip, string porta)
        {
            InitializeComponent();
            this.ip = ip;
            this.porta = porta;
            Padroes.FormataFormsIniciais(this, "Cliente - Questão 07");
        }

        private bool DadosValidos()
        {
            int idade, tempo;
            if (string.IsNullOrWhiteSpace(TxbIdade.Text) || (int.TryParse(TxbIdade.Text, out idade) && idade <0))
            {
                MessageBox.Show("Idade incorreta digitada.");
                return false;
            }
            if(string.IsNullOrWhiteSpace(TxbTempo.Text) || int.TryParse(TxbTempo.Text, out tempo) && tempo < 0)
            {
                MessageBox.Show("Tempo incorreto digitado.");
                return false;
            }
            if (tempo >= idade - 18)
            {
                MessageBox.Show("Verifique o tempo e idade informado.");
                return false;
            }
            return true;
        }
    }
}
