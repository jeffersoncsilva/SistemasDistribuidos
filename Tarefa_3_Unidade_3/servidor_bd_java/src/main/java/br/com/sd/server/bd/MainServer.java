package br.com.sd.server.bd;

import br.com.sd.server.bd.dao.Questao9DAO;
import br.com.sd.server.bd.model.Questao9;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class MainServer {
    final static int PORTA = 12345;

    public static void main(String[] args){
        try {
            System.out.println("Iniciando servidor de dados na porta: " + PORTA);
            ServerSocket server = new ServerSocket(PORTA, 8);
            Socket client;
            while(true){
                client = server.accept();
                new ServerConnection(client).start();
            }
        }catch (IOException io){
            System.out.println("Erro ao criar o socket do servidor.");
        }
        /* Usado para crair o baralho no banco de dados.
        Questao9DAO q = new Questao9DAO();
        String[] naipe = { "Copas", "Ouros","Espada", "Paus" };
        String[] valor = { "Ás", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove", "Dez", "Valete", "Dama", "Rei" };
        for(int n = 0; n <= 3; n++){
            for(int j = 0; j <= 12; j++) {
                q.save(new Questao9(valor[j], naipe[n]));
            }
        }
        */
    }
}
