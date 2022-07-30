import org.zeromq.SocketType;
import org.zeromq.ZContext;
import org.zeromq.ZMQ;

public class SubscriberQuestao9 {
    final static String str_bind = "tcp://127.0.0.1:13546";
    public static void main(String[] args){
        try(ZContext con = new ZContext()){
            ZMQ.Socket subs = con.createSocket(SocketType.SUB);
            subs.connect(str_bind);
            subs.subscribe("Questao9".getBytes(ZMQ.CHARSET));
            while (true) {
                // le o topico
                String topico = subs.recvStr();
                // le os dados
                String dados = subs.recvStr();
                System.out.println(dados);
            }
        }
    }
}
