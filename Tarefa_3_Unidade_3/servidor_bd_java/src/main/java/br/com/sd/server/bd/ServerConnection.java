package br.com.sd.server.bd;

import br.com.sd.server.bd.dao.*;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.InetAddress;
import java.net.Socket;

public class ServerConnection extends Thread{
    Socket client;
    PrintWriter writer = null;
    BufferedReader reader = null;
    public ServerConnection(Socket s){
        this.client = s;
    }

    public void run(){
        try{
            InetAddress net = client.getInetAddress();
            System.out.println("Local: " + client.getLocalSocketAddress().toString());
            System.out.println("Conexão recebida de: " + net.getHostAddress());
            writer = new PrintWriter(client.getOutputStream(), true);
            reader = new BufferedReader(new InputStreamReader(client.getInputStream()));
            String solicitacao = reader.readLine();
            System.out.print("Solicitação recebida: ");
            System.out.println(solicitacao);
            String resposta = tratarSolicitacao(solicitacao);
            writer.println(resposta);
            writer.close();
            reader.close();
            client.close();
        }catch (IOException io){
            System.out.println("Erro ao ler os dados da requisição pelo socket.");
            System.out.println(io.toString());
        }
    }
    private String tratarSolicitacao(String sol){
        // Recebe: QUESTAO$OPERACAO$PARAMETRO_ADICIONAL
        String[] str = sol.split("[$]");
        int questao = Integer.parseInt(str[0]);
        switch (questao){
            case 1:
                System.out.println("Recebido solicitação do exercicio 1");
                return trataQuestao(str, new Questao1DAO());
            case 2:
                System.out.println("Recebido solicitação do exercicio 2");
                return trataQuestao(str, new Questao2DAO());
            case 3:
                System.out.println("Recebido solicitação do exercicio 3");
                return trataQuestao(str, new Questao3DAO());
            case 4:
                System.out.println("Recebido solicitação do exercicio 4");
                return trataQuestao(str, new Questao4DAO());
            case 5:
                System.out.println("Recebido solicitação do exercicio 5");
                return trataQuestao(str, new Questao5DAO());
            case 6:
                System.out.println("Recebido solicitação do exercicio 6");
                return trataQuestao(str, new Questao6DAO());
            case 7:
                System.out.println("Recebido solicitação do exercicio 7");
                return trataQuestao(str, new Questao7DAO());
            case 8:
                System.out.println("Recebido solicitação do exercicio 8");
                return trataQuestao(str, new Questao8DAO());
            case 9:
                System.out.println("Recebido solicitação do exercicio 9");
                return trataQuestao(str, new Questao9DAO());
        }
        return "Solicitação não implementada ainda!";
    }
    private String trataQuestao(String[] p, IQuestaoDAO dao){
        int op = Integer.parseInt(p[1]);
        switch (op){
            case 1:
                return dao.findAllJsonFormat();
            case 2:
                return dao.findByIdJsonFormat(Long.parseLong(p[2]));
        }
        return "Operação não encontrada.";
    }
}
