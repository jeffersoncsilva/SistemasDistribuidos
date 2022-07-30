using System.Text.Json.Serialization;

namespace Servidor_de_Regra_de_Negocio
{
    internal class Questao3 : Questao
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("n1")]
        public int N1 { get; set; }
        [JsonPropertyName("n2")]
        public int N2 { get; set; }
        [JsonPropertyName("n3")]
        public int N3 { get; set; }

        public override void AplicarRegra()
        {
            double m = (N1 + N2) / 2;
            if (m >= 7)
                res = "Aprovado.";
            else if (m >= 3 && m < 7)
            {
                if ((m + N3) / 2 >= 5)
                    res = "Aprovado";
                else
                    res = "Reprovado";
            }
            else
                res = "Reprovado";

        }
    }
}
