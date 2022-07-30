using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Cliente
{
    internal class Questao1
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} - Cargo: {Cargo} - Salario reajustado: {Salario}";
        }
    }
}
