using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trarefa_Um.Clientes;

namespace Trarefa_Um.FormsClientes
{
    public partial class FrmQuestao2 : Form
    {
        string ip, porta;
        public FrmQuestao2(string ip, string porta)
        {
            InitializeComponent();
            Padroes.FormataFormsIniciais(this, "Cliente - Questão 2");
            this.ip = ip;
            this.porta = porta;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var nome = txbNome.Text;
            int sexo = -1;
            if (rdbFeminino.Checked)
                sexo = 1;
            else if (rdbMasculino.Checked)
                sexo = 0;
            var idade = int.Parse(txbIdade.Text);
            var cliente = new ClienteQuestao02(ip, porta, nome, sexo, idade);
            var resultado = cliente.EnviaDadosServidor();
            MessageBox.Show(resultado);
            cliente.EncerraConexao();
        }
    }
}
