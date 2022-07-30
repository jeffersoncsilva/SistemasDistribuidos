import org.zeromq.SocketType;
import org.zeromq.ZContext;
import org.zeromq.ZMQ;

import java.util.Random;

public class PublisherQuestao4 {
    final static String str_bind = "tcp://*:13546";

    static String[] dados = {
            "1$165",
            "0$176",
            "1$150",
            "0$189",
            "1$210",
            "0$198",
            "1$209",
            "0$162"
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
                    s.sendMore("Questao4".getBytes(ZMQ.CHARSET));
                    // Mensagem referente ao topico
                    s.send(dados[r.nextInt(dados.length)]);
                    System.out.println("Publicação feita.");
                }catch (Exception e){

                }
            }
        }
    }
}
