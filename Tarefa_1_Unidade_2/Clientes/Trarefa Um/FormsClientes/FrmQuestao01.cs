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

namespace Trarefa_Um
{
    public partial class FrmQuestao01 : Form
    {
        private string ip, porta;
        public FrmQuestao01(string ip, string porta)
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
                ClienteQuestao01 cl01 = new ClienteQuestao01(this.ip, this.porta, nome, cargo, salario);
                string resultado = cl01.EnviaDadosServidor();
                string[] res = resultado.Split("_$_");
                if (res.Length > 1)
                    MessageBox.Show($"Seu nome é {res[0]};\ntem o cargo de {res[1]}; \nSeu novo salário e de: R${res[2]}");
                else
                    MessageBox.Show("Erro ao enviar dados ao servidor.");
            }
            catch (DadosInvalidosException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
