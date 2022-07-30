using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Servidor_de_Regra_de_Negocio
{
    internal class Questao6 : Questao
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("nivel")]
        public string Nivel { get; set; }
        [JsonPropertyName("salario")]
        public double Salario { get; set; }
        [JsonPropertyName("dependentes")]
        public int Dependentes { get; set; }

        public override void AplicarRegra()
        {
            switch (Nivel)
            {
                case "A":
                    Salario = (Dependentes == 0) ? Salario * 0.97 : Salario * 0.92;
                    break;
                case "B":
                    Salario = (Dependentes == 0) ? Salario * 0.95 : Salario * 0.8;
                    break;
                case "C":
                    Salario = (Dependentes == 0) ? Salario * 0.92 : Salario * 0.85;
                    break;
                case "D":
                    Salario = (Dependentes == 0) ? Salario * 0.9 : Salario * 0.83;
                    break;
            }
            res = String.Format("O senhor {0} tem um salario de R$ {1:C2} e pertence ao nivel {2}.", Nome, Salario, Nivel);
        }
    }
}
