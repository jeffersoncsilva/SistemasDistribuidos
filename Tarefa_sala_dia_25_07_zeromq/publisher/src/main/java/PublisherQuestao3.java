import org.zeromq.SocketType;
import org.zeromq.ZContext;
import org.zeromq.ZMQ;

import java.util.Random;

public class PublisherQuestao3 {
    final static String str_bind = "tcp://*:13546";

    static String[] dados = {
            "8$5$2",
            "5$2$3",
            "6$10$3",
            "10$10$0",
            "10$0$5",
            "9$6$4",
            "8$6$3",
            "3$9$10"
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
                    s.sendMore("Questao3".getBytes(ZMQ.CHARSET));
                    // Mensagem referente ao topico
                    s.send(dados[r.nextInt(dados.length)]);
                    System.out.println("Publicação feita.");
                }catch (Exception e){

                }
            }
        }
    }
}
