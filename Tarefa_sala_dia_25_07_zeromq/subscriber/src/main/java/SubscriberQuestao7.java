import org.zeromq.SocketType;
import org.zeromq.ZContext;
import org.zeromq.ZMQ;

public class SubscriberQuestao7 {
    final static String str_bind = "tcp://127.0.0.1:13546";
    public static void main(String[] args){
        try(ZContext con = new ZContext()){
            ZMQ.Socket subs = con.createSocket(SocketType.SUB);
            subs.connect(str_bind);
            subs.subscribe("Questao7".getBytes(ZMQ.CHARSET));
            while (true) {
                // le o topico
                String topico = subs.recvStr();
                // le os dados
                String r = subs.recvStr();
                String[] dados= r.split("[$]");
                int idade = Integer.parseInt(dados[0]);
                int tempo = Integer.parseInt(dados[1]);
                if((idade >= 65 && tempo >= 30) || (idade >= 60 && tempo >= 25))
                {
                    System.out.println("Pode se aposentar.");
                }else
                    System.out.println("Nao pode se aposentar.");
            }
        }
    }
}
