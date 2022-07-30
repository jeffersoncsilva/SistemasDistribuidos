using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Cliente
{
    internal class ErroConexaoException : Exception
    {
        public ErroConexaoException(string msg) : base(msg)
        {
            
        }
    }
}
