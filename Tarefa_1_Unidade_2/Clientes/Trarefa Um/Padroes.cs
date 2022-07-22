using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trarefa_Um
{
    public static class Padroes
    {
        public const int PORTA_PADRAO = 12345;
        public const string IP_PADRAO = "127.0.0.1";
        public const char PADRAO_SEPARADOR = '$';

        public static string GeraMensagem(object[] objs)
        {
            string str = "";
            for (int i = 0; i < objs.Length; i++)
                str += $"{PADRAO_SEPARADOR}{objs[i]}";
            str += '\n';
            return str;
        }

        public static void FormataFormsIniciais(Form f, String nomeForm)
        {
            FormatacaoComum(f);
            f.Text = nomeForm;
        }

        private static void FormatacaoComum(Form f)
        {
            f.FormBorderStyle = FormBorderStyle.FixedSingle;
            f.MaximizeBox = false;
            f.StartPosition = FormStartPosition.CenterScreen;
        }

        public static string[] DivideMensagem(string msg) => msg.Split(PADRAO_SEPARADOR);
    }
}
