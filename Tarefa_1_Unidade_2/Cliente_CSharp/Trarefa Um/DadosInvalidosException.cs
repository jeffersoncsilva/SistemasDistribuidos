using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trarefa_Um
{
    public class DadosInvalidosException : Exception
    {
        public DadosInvalidosException(string msg): base(msg) { }
    }
}
