using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Servidor_de_Regra_de_Negocio
{
    internal class Questao8 : Questao
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("salario_medio")]
        public double Salario { get; set; }

        public override void AplicarRegra()
        {
            double cred = 0;
            if (Salario > 0 && Salario <= 200)
                res =  "Não tem saudo de credito.";
            else if (Salario > 200 && Salario <= 400)
                cred = Salario * 0.2;
            else if (Salario > 400 && Salario <= 600)
                cred = Salario * 0.3;
            else if (Salario > 600)
                cred = Salario * 0.4;

            res = $"A media de saldo e: R$ {Salario} e o credito disponivel e de: R${cred}";
        }
    }
}
