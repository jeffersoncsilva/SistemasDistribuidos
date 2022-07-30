using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Servidor_de_Regra_de_Negocio
{
    internal class Questao1 : Questao
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("cargo")]
        public string Cargo { get; set; }
        [JsonPropertyName("salario")]
        public double Salario { get; set; }

        public override void AplicarRegra()
        {
            if (Cargo.Equals("Operador"))
                Salario *= 1.2;
            else if (Cargo.Equals("Programador"))
                Salario *= 1.18;
            res = $"Nome: {Nome} - Cargo: {Cargo} - Salario reajustado: {Salario}";
        }
    }
}
