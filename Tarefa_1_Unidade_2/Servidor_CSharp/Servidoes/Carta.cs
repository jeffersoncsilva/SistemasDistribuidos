using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidoes
{
    internal class Carta
    {
        public string Valor { get; set; }
        public string Naipe { get; set; }

        public Carta(string valor, string naipe)
        {
            Valor = valor;
            Naipe = naipe;
        }

        public override string ToString()
        {
            return $"{Valor} de {Naipe}";
        }
    }
}
