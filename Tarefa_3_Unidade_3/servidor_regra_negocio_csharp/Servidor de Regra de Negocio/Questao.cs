using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor_de_Regra_de_Negocio
{
    internal abstract class Questao
    {
        protected string res = "";

        public abstract void AplicarRegra();

        public override string ToString()
        {
            return res;
        }
        
    }
}
