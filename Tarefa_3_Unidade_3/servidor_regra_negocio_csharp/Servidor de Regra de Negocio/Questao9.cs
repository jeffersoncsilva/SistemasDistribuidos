using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Servidor_de_Regra_de_Negocio
{
    internal class Questao9 : Questao
    {
        [JsonPropertyName("id")]
        public long Id
        {
            get; set;
        }
        [JsonPropertyName("valor")]
        public string Valor { get; set; }
        [JsonPropertyName("naipe")]
        public string Naipe { get; set; }

        public override void AplicarRegra()
        {
            
        }

        public override string ToString()
        {
            return $"{Valor} de {Naipe}";
        }
    }
}
