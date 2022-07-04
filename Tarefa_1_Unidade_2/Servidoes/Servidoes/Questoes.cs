﻿namespace Servidoes
{
    public static class Questoes
    {
        public static string TratarQuestao(int questao, string msg)
        {
            switch (questao)
            {
                case 0:
                    return Questao01(msg);
                case 1:
                    return Questao02(msg);
                case 2:
                    return Questao03(msg);
                case 3:
                    return Questao04(msg);
                case 4:
                    return Questao05(msg);
                case 5:
                    return Questao06(msg);
                case 6:
                    return Questao07(msg);
                case 7:
                    return Questao08(msg);
                case 8:
                    return Questao09(msg);
                default:
                    return "Opção nao encontrada!";

            }
        }

        private static string Questao01(string ms)
        {
            string[] msg = ms.Split(Padroes.PADRAO_SEPARADOR);
            double salario = double.Parse(msg[2]);
            int cargo = int.Parse(msg[1]);
            msg[2] = $"{CalculaSalarioReajustado(salario, cargo)}";
            return Padroes.GeraMensagem(msg);
        }
        
        private static double CalculaSalarioReajustado(double salario, int cargo) => (cargo == 0) ? salario * 1.2 : salario * 1.18;
        
        private static string Questao02(string msg)
        {
            string[] msgs = Padroes.DivideMensagem(msg);
            var idade = int.Parse(msgs[2]);
            var sexo = int.Parse(msgs[1]);
            if (sexo == 1 && idade > 21)
                return "Maioridade Atingida.";
            else if (sexo == 0 && idade >= 18)
                return "Maioridade Atingida";
            else
                return "Maioridade não Atingida.";
        }

        private static string Questao03(string msg)
        {
            // Recebido um vetor de 3 posições contento a mensagem que é enviada.
            string[] ms = Padroes.DivideMensagem(msg);
            int a, b, c;
            int.TryParse(ms[0], out a);
            int.TryParse(ms[1], out b);
            int.TryParse(ms[2], out c);
            double m1 = (a + b) / 2;
            if (m1 >= 7)
                return "Aprovado";
            else if ((m1 >= 3 && m1 <= 7))
                return "Deve fazer N3";
            else if ((m1 + c) / 2 >= 5)
                return ("Aprovado");
            else
                return ("Reprovado");            
        }

        private static string Questao04(string msg)
        {
            string[] ms = Padroes.DivideMensagem(msg);
            int sexo = int.Parse(ms[0]);
            double altura = double.Parse(ms[1]);
            double peso;
            if (sexo == 1)
                peso = ((72.7 * altura) - 58);
            else if (sexo == 0)
                peso = (62.1 * altura - 44.7);
            else
                return "Peso errado enviado.";
            return $"O peso ideal e: {peso.ToString("F")}";
        }

        private static string Questao05(string msg)
        {
            int idade = int.Parse(msg);
            if (idade < 5)
                return "Muito novo para possuir categoria.";
            else if (idade >= 5 && idade <= 7)
                return "Categoria infantil A";
            else if (idade >= 8 && idade <= 10)
                return "Categoria infantil B";
            else if (idade >= 11 && idade <= 13)
                return "Categoria juvenil A";
            else if (idade >= 14 && idade <= 17)
                return "Categoria juvenil B";
            else if (idade >= 18)
                return "Categoria Adulto";
            return "";
        }
        
        private static string Questao06(string msg)
        {
            // nome, salario, dependentes, nivel
            string[] dados = Padroes.DivideMensagem(msg);
            double salario = double.Parse(dados[1]);
            int dependentes = int.Parse(dados[2]);
            char nivel = char.Parse(dados[3]);
            double salarioReajustado = 0;
            switch (nivel)
            {
                case 'A':
                    salarioReajustado = (dependentes == 0) ? salario * 0.97 : salario * 0.92;
                    break;
                case 'B':
                    salarioReajustado = (dependentes == 0) ? salario * 0.95 : salario * 0.8;
                    break;
                case 'C':
                    salarioReajustado = (dependentes == 0) ? salario * 0.92 : salario * 0.85;
                    break;
                case 'D':
                    salarioReajustado = (dependentes == 0) ? salario * 0.9 : salario * 0.83;
                    break;
            }
            return String.Format("O senhor {0} tem um salario de R$ {1:C2} e pertence ao nivel {2}.", dados[0], salarioReajustado, nivel);
        }
        
        private static string Questao07(string msg)
        {
            var dados = Padroes.DivideMensagem(msg);
            var idade = int.Parse(dados[0]);
            var tempo = int.Parse(dados[1]);
            if((idade >= 65 && tempo >= 30) || (idade >= 60 && tempo >= 25))
            {
                return "Pode se aposentar.";
            }
            return "Nao pode se aposentar.";
        }
        
        private static string Questao08(string msg)
        {
            return "";
        }
        private static string Questao09(string msg)
        {
            return "";
        }
    }
}
