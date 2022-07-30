import org.zeromq.SocketType;
import org.zeromq.ZContext;
import org.zeromq.ZMQ;

import java.util.Random;

public class PublisherQuestao5 {
    final static String str_bind = "tcp://*:13546";

    static String[] dados = {
            "3$1",
            "5$0",
            "8$0",
            "12$0",
            "15$0",
            "18$0",
            "17$0",
            "21$0"
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
                    s.sendMore("Questao5".getBytes(ZMQ.CHARSET));
                    // Mensagem referente ao topico
                    s.send(dados[r.nextInt(dados.length)]);
                    System.out.println("Publicação feita.");
                }catch (Exception e){

                }
            }
        }
    }
}
