import org.zeromq.SocketType;
import org.zeromq.ZContext;
import org.zeromq.ZMQ;

import java.util.Random;

public class PublisherQuestao7 {
    final static String str_bind = "tcp://*:13546";

    static String[] dados = {
            "25$5",
            "39$15",
            "45$14",
            "61$29",
            "89$74",
            "19$0",
            "23$0",
            "38$5"
    };

    public static void main(String[] args){
        Random r = new Random();
        try(ZContext context = new ZContext()){
            //ZMQ.Socket s = context.createSocket(ZMQ.XPUB);
            ZMQ.Socket s = context.createSocket(SocketType.PUB);
            s.bind(str_bind);
            while(true){
                try {
                    Thread.sleep(1000);
                    // Topico
                    s.sendMore("Questao7".getBytes(ZMQ.CHARSET));
                    // Mensagem referente ao topico
                    s.send(dados[r.nextInt(dados.length)]);
                    System.out.println("Publicação feita.");
                }catch (Exception e){

                }
            }
        }
    }
}
