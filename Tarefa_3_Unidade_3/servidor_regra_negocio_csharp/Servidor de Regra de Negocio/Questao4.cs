using System.Text.Json.Serialization;

namespace Servidor_de_Regra_de_Negocio
{
    internal class Questao4 : Questao
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("altura")]
        public int Altura { get; set; }
        [JsonPropertyName("sexo")]
        public string Sexo  { get; set; }

        public override void AplicarRegra()
        {
            if (Sexo.Equals("M"))
            {
                double p = (72.7 * Altura) - 58;
                res = $"O peso ideal e: {p}";
            }
            else if (Sexo.Equals("F"))
            {
                double p = (62.1 * Altura) - 44.7;
                res = $"O peso ideal e: {p}";
            }
            else
                res = "Erro ao calcular esse dado.";
        }
    }
}
