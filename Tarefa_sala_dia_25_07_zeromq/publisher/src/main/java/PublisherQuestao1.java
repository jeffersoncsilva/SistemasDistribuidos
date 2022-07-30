import org.zeromq.SocketType;
import org.zeromq.ZContext;
import org.zeromq.ZMQ;

import java.util.Random;

public class PublisherQuestao1 {
    final static String str_bind = "tcp://*:13546";

    static String[] dados = {
            "Manoel$Programador$15669",
            "Joel$Operador$2060",
            "Ferdinand$Programador$2600",
            "Josuelson$Operador$3489",
            "Joselei$Programador$2398",
            "Hefner$Operador$4290",
            "Hugie$Programador$1489",
            "Ocon$Operador$3567",
            "Alonso$Programador$3456",
            "Norris$Operador$9984",
            "Hamilton$Programador$10888",
            "Peres$Operador$9870",
            "Vetel$Programador$7890",
            "Leclerc$Operador$8934",
    };

    public static void main(String[] args){
        Random r = new Random();
        int pubs = 0;
        try(ZContext context = new ZContext()){
            //ZMQ.Socket s = context.createSocket(ZMQ.XPUB);
            ZMQ.Socket s = context.createSocket(SocketType.PUB);
            s.bind(str_bind);
            while(true){
                try {
                    Thread.sleep(1000);
                    // Topico
                    s.sendMore("Questao1".getBytes(ZMQ.CHARSET));
                    // Mensagem referente ao topico
                    s.send(dados[r.nextInt(14)]);
                    System.out.println("Publicação feita.");
                }catch (Exception e){

                }
            }
        }
    }
}
