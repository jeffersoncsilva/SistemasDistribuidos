using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidoes
{
    public static class Padroes
    {
        public const int PORTA_PADRAO = 12345;
        public const string IP_PADRAO = "127.0.0.1";
        public const char PADRAO_SEPARADOR = '$';


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

        public static string GeraMensagem(object[] objs)
        {
            string str = "";
            for (int i = 0; i < objs.Length; i++)
                str += $"{PADRAO_SEPARADOR}{objs[i]}";
            return str;
        }

        public static string[] DivideMensagem(string msg) {
            var sep = msg.Substring(0, 1);
            msg = msg.Substring(3);
            return msg.Split(sep);
        }

    }
}
