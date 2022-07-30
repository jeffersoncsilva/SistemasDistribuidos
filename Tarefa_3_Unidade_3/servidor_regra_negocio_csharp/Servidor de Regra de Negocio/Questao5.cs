using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Servidor_de_Regra_de_Negocio
{
    internal class Questao5 : Questao
    {
        [JsonPropertyName("id")]
        public long ID { get; set; }
        [JsonPropertyName("idade")]
        public int Idade { get; set; }
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        public override void AplicarRegra()
        {
            if (Idade < 5)
                res = "Não pode participar.";
            else if (Idade <= 7 && Idade >= 5)
                res = "Categoria Infantil A";
            else if (Idade <= 10 && Idade >= 8)
                res = "Categoria Infantil B";
            else if (Idade <= 13 && Idade >= 11)
                res = "Categoria Juvenil A";
            else if (Idade <= 17 && Idade >= 14)
                res = "Categoria Juvenil B";
            else if (Idade >= 18)
                res = "Categoria Adulto";
        }
    }
}
