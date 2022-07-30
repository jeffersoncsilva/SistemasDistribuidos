import org.zeromq.SocketType;
import org.zeromq.ZContext;
import org.zeromq.ZMQ;

import java.util.Random;

public class PublisherQuestao6 {
    final static String str_bind = "tcp://*:13546";

    static String[] dados = {
            "3000$1$A",
            "5000$0$D",
            "8000$0$C",
            "12000$8$B",
            "15000$2$A",
            "18000$3$B",
            "1700$0$C",
            "2010$0$D"
    };

    public static void main(String[] args){
        Random r = new Random();
        try(ZContext context = new ZContext()){
            ZMQ.Socket s = context.createSocket(SocketType.PUB);
            s.bind(str_bind);
            while(true){
                try {
                    Thread.sleep(1000);
                    // Topico
                    s.sendMore("Questao6".getBytes(ZMQ.CHARSET));
                    // Mensagem referente ao topico
                    s.send(dados[r.nextInt(dados.length)]);
                    System.out.println("Publicação feita.");
                }catch (Exception e){

                }
            }
        }
    }
}
