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
    public partial class FrmQuestao8 : Form
    {
        private string ip, porta;

        private void BtnCalcula_Click(object sender, EventArgs e)
        {
            BtnCalcula.Enabled = false;
            var c = new Client(ip, porta);
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Insira um valor valido.");
            }
            else
            {
                var d = textBox1.Text;
                var res = c.EnviaDadosServidor(Padroes.GeraMensagem(new object[] { 8, d }));
                MessageBox.Show(res);
                c.EncerraConexao();
            }
            BtnCalcula.Enabled = false;
            
        }

        public FrmQuestao8(string ip, string porta)
        {
            InitializeComponent();
            this.ip = ip;
            this.porta = porta;
            Padroes.FormataFormsIniciais(this, "Cliente - Questão 8");
            
        }
    }
}
