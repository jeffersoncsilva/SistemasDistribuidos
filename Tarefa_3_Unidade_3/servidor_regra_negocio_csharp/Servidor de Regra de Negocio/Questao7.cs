using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Servidor_de_Regra_de_Negocio
{
    internal class Questao7 : Questao
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("idade")]
        public int Idade { get; set; }
        [JsonPropertyName("tempo_trabalho")]
        public int Tempo_Trabalho { get; set; }

        public override void AplicarRegra()
        {
            if ((Idade >= 65 && Tempo_Trabalho >= 30) || (Idade >= 60 && Tempo_Trabalho >= 25))
            {
                res = "Pode se aposentar.";
            }
            res = "Nao pode se aposentar.";
        }
    }
}
