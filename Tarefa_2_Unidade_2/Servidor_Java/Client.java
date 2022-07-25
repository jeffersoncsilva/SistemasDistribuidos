import java.io.*;
import java.net.Socket;
import java.net.UnknownHostException;
import java.util.Scanner;

public class Client {
    static String[] buffer;
    static Scanner in = new Scanner(System.in);

    public static void Main(String[] args){

        int escolha = 0;
        System.out.println("Iniciando programa cliente.");
        do {
            System.out.println("Escolha um exercicio: ");
            System.out.println("1 - Questão 1");
            System.out.println("2 - Questão 2");
            System.out.println("3 - Questão 3");
            System.out.println("4 - Questão 4");
            System.out.println("5 - Questão 5");
            System.out.println("6 - Questão 6");
            System.out.println("7 - Questão 7");
            System.out.println("8 - Questão 8");
            System.out.println("9 - Sair");
            escolha = in.nextInt();
            printaOpcaoEntrada(escolha);

            System.out.print("\n\nDigite o IP a ser conectado: ");
            String ip = in.nextLine();
            System.out.print("\nDigite a porta: ");
            int porta = in.nextInt();

            try {
                Socket client = new Socket(ip, porta);
                BufferedReader reader = new BufferedReader(new InputStreamReader(client.getInputStream()));
                PrintWriter writer = new PrintWriter(client.getOutputStream(), true);
                writer.println(juntarMensagem(escolha));
                System.out.println("Dados enviados. Aguardando resposta...");
                String resp = reader.readLine();
                System.out.println("\nDados recebidos: " + resp);
                writer.close();
                reader.close();
                client.close();
            }catch(UnknownHostException e){
                System.out.println("Host não encontrado. " + e.getMessage());
            }
            catch (IOException e) {
                System.out.println("Erro ao conectar. " + e.getMessage());
            }

        }while(escolha >= 1 && escolha <= 8);
    }
    static String juntarMensagem(int questao){
        String msg = "$"+questao;
        for(String s : buffer)
            msg += "$"+s;
        return msg;
    }
    static void printaOpcaoEntrada(int escolha){
        switch (escolha){
            case 1:
                entradaDadosQuestao1();
                break;
            case 2:
                entradaDadosQuestao2();
                break;
            case 3:
                entradaDadosQuestao3();
                break;
            case 4:
                entradaDadosQuestao4();
                break;
            case 5:
                entradaDadosQuestao5();
                break;
            case 6:
                entradaDadosQuestao6();
                break;
            case 7:
                entradaDadosQuestao7();
                break;
            case 8:
                entradaDadosQuestao8();
                break;
        }
    }
    static void entradaDadosQuestao1(){
        buffer = new String[3];
        System.out.print("\nDigite o nome: ");
        buffer[0] = in.nextLine();
        System.out.print("\nDigite o cargo: ");
        buffer[1] = in.nextLine();
        System.out.print("\nDigite o salario: ");
        buffer[2] = in.nextLine();
    }
    static void entradaDadosQuestao2(){
        buffer = new String[3];
        System.out.print("\nDigite seu nome: ");
        buffer[0] = in.nextLine();
        System.out.print("\nEscolha: \n1 - Sexo Masculino\n2 - Sexo Feminino");
        buffer[1] = in.nextLine();
        System.out.print("\nDigite a idade: ");
        buffer[2] = in.nextLine();
    }
    static void entradaDadosQuestao3(){
        buffer = new String[3];
        System.out.print("\nDigite a nota 1: ");
        buffer[0] = in.nextLine();
        System.out.print("\nDigite a nota 2: ");
        buffer[1] = in.nextLine();
        System.out.print("\nDigite a nota 3: ");
        buffer[2] = in.nextLine();
    }
    static void entradaDadosQuestao4(){
        buffer = new String[2];
        System.out.print("\nEscolha: \n1 - Sexo Masculino\n2 - Sexo Feminino");
        buffer[0] = in.nextLine();
        System.out.print("\nDigite sua altura em centimetros: ");
        buffer[1] = in.nextLine();
    }
    static void entradaDadosQuestao5(){
        buffer = new String[1];
        System.out.print("\nDigite sua idade: ");
        buffer[0] = in.nextLine();
    }
    static void entradaDadosQuestao6(){
        buffer = new String[4];
        System.out.print("Digite o nome: ");
        buffer[0] = in.nextLine();
        System.out.print("\nDigite o salário: ");
        buffer[1] = in.nextLine();
        System.out.print("\nDigite os dependentes: ");
        buffer[2] = in.nextLine();
        System.out.print("\nEscolha um nível: \nA - nível A\nB - nível B\nC - nível C\nD - nível D");
        buffer[3] = in.nextLine();
    }
    static void entradaDadosQuestao7(){
        buffer = new String[2];
        System.out.print("\nDigite sua idade: ");
        buffer[0] = in.nextLine();
        System.out.print("\nDigite o tempo de serviço: ");
        buffer[1] = in.nextLine();
    }
    static void entradaDadosQuestao8(){
        buffer = new String[1];
        System.out.print("\nDigite a média salárial: ");
        buffer[0] = in.nextLine();
    }

}
