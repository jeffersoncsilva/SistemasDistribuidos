import org.zeromq.SocketType;
import org.zeromq.ZContext;
import org.zeromq.ZMQ;

import java.util.Random;

public class PublisherQuestao2 {
    final static String str_bind = "tcp://*:13546";

    static String[] dados = {
            "22$1",
            "55$0",
            "15$0",
            "18$1",
            "19$0",
            "21$1",
            "20$0",
            "18$1"
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
                    s.sendMore("Questao2".getBytes(ZMQ.CHARSET));
                    // Mensagem referente ao topico
                    s.send(dados[r.nextInt(dados.length)]);
                    System.out.println("Publicação feita.");
                }catch (Exception e){
                    System.out.println("Erro ao publicar.");
                    System.out.println(e.getMessage());
                }
            }
        }
    }
}
