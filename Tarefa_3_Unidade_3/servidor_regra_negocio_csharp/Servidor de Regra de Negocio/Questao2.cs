using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Servidor_de_Regra_de_Negocio
{
    internal class Questao2 : Questao
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("sexo")]
        public string Sexo { get; set; }
        [JsonPropertyName("idade")]
        public int Idade { get; set; }       
        
        public override void AplicarRegra()
        {
            if (Sexo.Equals("M"))
                res = (Idade >= 18) ? $"Maioridade já foi atingida.\n" : "Maioridade não atingida.\n";
            else if (Sexo.Equals("F"))
                res = (Idade >= 21) ? $"Maioridade já foi atingida.\n" : "Maioridade não atingida.\n";
        }
    }
}
