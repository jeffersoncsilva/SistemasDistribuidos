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
    public partial class FrmQuestao4 : Form
    {
        private string ip, porta;
        private Client client;

        private int sexo = -1;
        private double altura = -1;

        private void BtnCalcula_Click(object sender, EventArgs e)
        {
            BtnCalcula.Enabled = false;
            this.client = new Client(ip, porta);
            if (RbFeminino.Checked)
                sexo = 0;
            else if (rbMasculino.Checked)
                sexo = 1;
            else {
                BtnCalcula.Enabled = true;
                throw new DadosInvalidosException("Dados de sexo incorretos.");
            }
            altura = double.Parse(TxbNome.Text);
            var res = this.client.EnviaDadosServidor(Padroes.GeraMensagem(new object[] { 4, sexo, altura }));
            MessageBox.Show(res);
            this.client.EncerraConexao();
            BtnCalcula.Enabled = true;
        }

        public FrmQuestao4(string ip, string porta)
        {
            this.ip = ip;
            this.porta = porta;
            InitializeComponent();
            Padroes.FormataFormsIniciais(this, "Cliente - Questao 04");
        }

    }
}
