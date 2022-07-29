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
    public partial class FrmQuestao9 : Form
    {
        private string ip, porta;
        private Client? client = null;
        private int idItem = 0;

        public FrmQuestao9(string ip, string porta)
        {            
            InitializeComponent();
            this.ip = ip;
            this.porta = porta;
            Padroes.FormataFormsIniciais(this, "Questao 09 - Cliente");
            PopulaListViewParaTeste();
        }

        private void BtnPegarCarta_Click(object sender, EventArgs e)
        {
            BtnPegarCarta.Enabled = false;
            client = new Client(this.ip, this.porta);
            string? res = client.EnviaDadosServidor("$9\n");
            if(res != null)
                AdicionaItemNaLista(res);
            BtnPegarCarta.Enabled = true;
        }

        private void PopulaListViewParaTeste()
        {
            AdicionaItemNaLista("As (A) de paus");
            AdicionaItemNaLista("Três (3) de Ouro");
            AdicionaItemNaLista("Sete(7) de Valete");
            AdicionaItemNaLista("Des (10) de Coração");
        }

        private void AdicionaItemNaLista(string item)
        {
            var i = new ListViewItem($"{idItem++}");
            i.SubItems.Add(item);
            LstCartas.Items.Add(i);            
        }
    }
}
