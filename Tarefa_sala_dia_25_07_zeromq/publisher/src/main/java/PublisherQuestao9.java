import org.zeromq.SocketType;
import org.zeromq.ZContext;
import org.zeromq.ZMQ;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Random;

public class PublisherQuestao9 {
    final static String str_bind = "tcp://*:13546";

    static List<Carta> cartas;

    public static void main(String[] args){
        Random r = new Random();
        criarBaralho();
        try(ZContext context = new ZContext()){
            //ZMQ.Socket s = context.createSocket(ZMQ.XPUB);
            ZMQ.Socket s = context.createSocket(SocketType.PUB);
            s.bind(str_bind);
            while(true){
                try {
                    Thread.sleep(1000);
                    // Topico
                    s.sendMore("Questao9".getBytes(ZMQ.CHARSET));
                    // Mensagem referente ao topico
                    s.send(cartas.get(r.nextInt(cartas.size())).toString());
                    System.out.println("Publicação feita.");
                }catch (Exception e){

                }
            }
        }
    }

    private static void criarBaralho(){
        cartas = new ArrayList<Carta>();
        criarCartas(cartas);
        criarCartas(cartas);
        Collections.shuffle(cartas);
    }

    private static void criarCartas(List<Carta> c){
        String[] naipe = { "Copas", "Ouros","Espada", "Paus" };
        String[] valor = { "Ás", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove", "Dez", "Valete", "Dama", "Rei" };
        for(int n = 0; n <= 3; n++)
        {
            for(int j = 0; j <= 12; j++)
            {
                c.add(new Carta(valor[j], naipe[n]));
            }

        }
    }
}
