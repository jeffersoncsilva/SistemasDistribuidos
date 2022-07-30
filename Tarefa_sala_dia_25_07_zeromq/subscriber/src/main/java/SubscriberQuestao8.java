import org.zeromq.SocketType;
import org.zeromq.ZContext;
import org.zeromq.ZMQ;

public class SubscriberQuestao8 {
    final static String str_bind = "tcp://127.0.0.1:13546";
    public static void main(String[] args){
        try(ZContext con = new ZContext()){
            ZMQ.Socket subs = con.createSocket(SocketType.SUB);
            subs.connect(str_bind);
            subs.subscribe("Questao8".getBytes(ZMQ.CHARSET));
            while (true) {
                // le o topico
                String topico = subs.recvStr();
                // le os dados
                String dados = subs.recvStr();
                String[] s= dados.split("[$]");

                double res = Double.parseDouble(s[0]);
                double cred = 0;
                if (res > 0 && res <= 200){
                    System.out.println( "Não tem saudo de credito.");
                    continue;
                }
                else if (res > 200 && res <= 400)
                    cred = res * 0.2;
                else if (res > 400 && res <= 600)
                    cred = res * 0.3;
                else if (res > 600)
                    cred = res * 0.4;

                System.out.println(String.format("A media de saldo e: R$ %f e o credito disponivel e de: R$%f", res, cred));
            }
        }
    }
}
