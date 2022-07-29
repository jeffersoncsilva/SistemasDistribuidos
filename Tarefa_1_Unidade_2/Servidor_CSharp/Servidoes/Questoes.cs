namespace Servidoes
{
    public static class Questoes
    {
        private static List<Carta>? cartas = null;

        public static string TratarQuestao(string msg)
        {
            var op = msg.Substring(1, 1);
            if (int.TryParse(op, out int questao))
            {
                switch (questao)
                {
                    case 1:
                        return Questao01(msg);
                    case 2:
                        return Questao02(msg);
                    case 3:
                        return Questao03(msg);
                    case 4:
                        return Questao04(msg);
                    case 5:
                        return Questao05(msg);
                    case 6:
                        return Questao06(msg);
                    case 7:
                        return Questao07(msg);
                    case 8:
                        return Questao08(msg);
                    case 9:
                        return Questao09(msg);
                    default:
                        return "Opção nao encontrada!";

                }
            }
            else
            {
                return "Ocorreu um erro ao tratar mensagem.";
            }
        }

        private static string Questao01(string ms)
        {
            string[] msg = Padroes.DivideMensagem(ms);
            double salario = double.Parse(msg[2]);
            int cargo = int.Parse(msg[1]);
            var sal = CalculaSalarioReajustado(salario, cargo);
            return $"Nome: {msg[0]} - Novo salario: {sal}";
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
            var s = Padroes.DivideMensagem(msg);
            if (int.TryParse(s[0], out int idade))
            {
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
            }
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
            var r = Padroes.DivideMensagem(msg);
            if (!string.IsNullOrWhiteSpace(r[0]) && Double.TryParse(r[0], out double res))
            {
                double cred = 0;
                if (res > 0 && res <= 200)
                    return "Não tem saudo de credito.";
                else if (res > 200 && res <= 400)
                    cred = res * 0.2;
                else if (res > 400 && res <= 600)
                    cred = res * 0.3;
                else if (res > 600)
                    cred = res * 0.4;

                return $"A media de saldo e: R$ {res} e o credito disponivel e de: R${cred}";
            }
            return "Dados não recebidos. Tente novamente.";
        }
        
        private static string Questao09(string msg)
        {
            var rnd = new Random();
            if (cartas == null)     
                CriarBaralho(rnd);
            
            return cartas != null ? $"{cartas[rnd.Next(cartas.Count)].ToString()}\n" : "Baralho não foi criado pelo servidor.\n";
        }

        private static void CriarBaralho(Random rnd)
        {
            cartas = new List<Carta>();
            // Cria 2 vezes para compor o baralho completo
            CriarCartas(cartas);
            CriarCartas(cartas);
            // Embaralha as cartas            
            var randomized = cartas.OrderBy(item => rnd.Next());
        }

        private static void CriarCartas(List<Carta> c)
        {
            string[] naipe = { "Copas", "Ouros","Espada", "Paus" };
            string[] valor = { "Ás", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove", "Dez", "Valete", "Dama", "Rei" };
            for(int n = 0; n <= 3; n++)
            {
                for(int j = 0; j <= 12; j++)
                {
                    c.Add(new Carta(valor[j], naipe[n]));
                }

            }
        }
    }
}
