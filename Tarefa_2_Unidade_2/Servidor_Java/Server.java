import java.io.*;
import java.net.InetAddress;
import java.net.ServerSocket;
import java.net.Socket;

public class Server {
    final static int PORTA = 12345;

    public static void main(String[] args) {
        try {
            ServerSocket server = new ServerSocket(PORTA, 5);
            Socket client;
            while(true) {
                System.out.println("Aguardando por conexão...");
                client = server.accept();
                InetAddress endClient = client.getInetAddress();
                System.out.println("Conectado com: " + endClient.getHostAddress());
                BufferedReader reader = new BufferedReader(new InputStreamReader(client.getInputStream()));
                PrintWriter writer = new PrintWriter(client.getOutputStream(), true);
                String dados = reader.readLine();
                System.out.println("Dados recebidos: " + dados);
                String sep = String.format("[%s]", dados.substring(0, 1));
                int questao = Integer.parseInt(dados.substring(1,2));
                String[] msg = dados.substring(3).split(sep, -1);
                String resposta = tratarQuestao(msg, questao);
                System.out.println("Dados que será enviado: " + resposta);
                writer.println(resposta);
            }
        }catch (IOException io){
            System.out.println("Erro no socket.");
        }
    }
    private static String tratarQuestao(String[] msg, int questao){
        //int questao = Integer.parseInt(msg[0]);
        switch (questao){
            case 1:
                return questaoUm(msg);
            case 2:
                return questaoDois(msg);
            case 3:
                return questaoTres(msg);
            case 4:
                return questaoQuatro(msg);
            case 5:
                return questaoCinco(msg);
            case 6:
                return questaoSeis(msg);
            case 7:
                return questaoSete(msg);
            case 8:
                return questaoOito(msg);
            default:
                return "Exercicio não encontrado.";
        }
    }
    private static String questaoUm(String[] dados){
        double salario = Double.parseDouble(dados[2]);
        int cargo = Integer.parseInt(dados[1]);
        salario = (cargo == 0) ? salario * 1.2 : salario * 1.18;
        return String.format("Nome: %s - Novo salário: %f", dados[0], salario);
    }
    private static String questaoDois(String[] dados){
        var idade = Integer.parseInt(dados[2]);
        var sexo = Integer.parseInt(dados[1]);
        if (sexo == 1 && idade > 21)
            return "Maioridade Atingida.";
        else if (sexo == 0 && idade >= 18)
            return "Maioridade Atingida";
        else
            return "Maioridade não Atingida.";
    }
    private static String questaoTres(String[] d){
        int a, b, c;
        a = Integer.parseInt(d[0]);
        b = Integer.parseInt(d[1]);
        c = Integer.parseInt(d[2]);
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
    private static String questaoQuatro(String[] d){
        int sexo = Integer.parseInt(d[0]);
        double altura = Double.parseDouble(d[1]);
        double peso;
        if (sexo == 1)
            peso = ((72.7 * altura) - 58);
        else if (sexo == 0)
            peso = (62.1 * altura - 44.7);
        else
            return "Peso errado enviado.";
        return String.format("O peso ideal e: %f.", peso);
    }
    private static String questaoCinco(String[] d){
        int idade = Integer.parseInt(d[0]);
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
        return "Idade nao encontrada.";
    }
    private static String questaoSeis(String[] dados){
        double salario = Double.parseDouble(dados[1]);
        int dependentes = Integer.parseInt(dados[2]);
        char nivel = dados[3].charAt(0);
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
        return String.format("O senhor %s tem um salario de R$ %f e pertence ao nivel %c.", dados[0], salarioReajustado, nivel);
    }
    private static String questaoSete(String[] dados){
        int idade = Integer.parseInt(dados[0]);
        int tempo = Integer.parseInt(dados[1]);
        if((idade >= 65 && tempo >= 30) || (idade >= 60 && tempo >= 25))
        {
            return "Pode se aposentar.";
        }
        return "Nao pode se aposentar.";
    }
    private static String questaoOito(String[] dados){
        double res = Double.parseDouble(dados[0]);
        double cred = 0;
        if (res > 0 && res <= 200)
            return "Não tem saudo de credito.";
        else if (res > 200 && res <= 400)
            cred = res * 0.2;
        else if (res > 400 && res <= 600)
            cred = res * 0.3;
        else if (res > 600)
            cred = res * 0.4;

        return String.format("A media de saldo e: R$ %f e o credito disponivel e de: R$%f", res, cred);
    }
}