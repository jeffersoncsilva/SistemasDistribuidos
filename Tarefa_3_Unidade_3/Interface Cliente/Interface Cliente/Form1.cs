using System.Text;
using System.Text.Json;

namespace Interface_Cliente
{
    public partial class Form1 : Form
    {
        private Cliente? c = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConectaServidor_Click(object sender, EventArgs e)
        {
            try
            {
                BtnConectaServidor.Enabled = false;
                if (String.IsNullOrWhiteSpace(TxbPortaServidor.Text) || String.IsNullOrWhiteSpace(TxbPortaServidor.Text))
                {
                    MessageBox.Show("Dados de porta e ip incorretos. Verifique e tente novamente.");
                    BtnConectaServidor.Enabled = true;
                    return;
                }
                if (int.TryParse(TxbPortaServidor.Text, out int port))
                {
                    
                    c = new Cliente(TxbIpServidor.Text, int.Parse(TxbPortaServidor.Text));
                    GpbQuestoes.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Valor incorreto para a porta do servidor.");
                    BtnConectaServidor.Enabled = true;
                }
            }catch(ErroConexaoException ex)
            {
                BtnConectaServidor.Enabled = true;
                MessageBox.Show("Erro ao se conectar ao servidor. Tente novamente.");
            }
            
        }

        private void BtnQuestao_Click(object sender, EventArgs e)
        {
            string str = ((Button)sender).Name;            
            SolicitaDados(str);
        }

        private void SolicitaDados(string msg)
        {
            var res = c.EnviaDadosServidor($"{msg}\n");
            List<string> data = JsonSerializer.Deserialize<List<string>>(res);
            StringBuilder sb = new StringBuilder();
            foreach (string i in data)
            {
                sb.Append(i);
                sb.Append("\n");
            }
            LblResult.Text = sb.ToString();
            c.EncerrarConexao();
            BtnConectaServidor.Enabled = true;
            GpbQuestoes.Enabled = false;
        }
    }
}