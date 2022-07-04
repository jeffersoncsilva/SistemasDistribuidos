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
        public FrmQuestao8(string ip, string porta)
        {
            InitializeComponent();
            this.ip = ip;
            this.porta = porta;
            Padroes.FormataFormsIniciais(this, "Cliente - Questão 8");
            
        }
    }
}
