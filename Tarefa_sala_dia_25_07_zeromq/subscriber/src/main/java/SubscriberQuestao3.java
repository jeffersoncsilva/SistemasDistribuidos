import org.zeromq.SocketType;
import org.zeromq.ZContext;
import org.zeromq.ZMQ;

public class SubscriberQuestao3 {
    final static String str_bind = "tcp://127.0.0.1:13546";
    public static void main(String[] args){
        try(ZContext con = new ZContext()){
            ZMQ.Socket subs = con.createSocket(SocketType.SUB);
            subs.connect(str_bind);
            subs.subscribe("Questao3".getBytes(ZMQ.CHARSET));
            while (true) {
                // le o topico
                String topico = subs.recvStr();
                // le os dados
                String dados = subs.recvStr();
                String[] s= dados.split("[$]");

                int a, b, c;
                a = Integer.parseInt(s[0]);
                b = Integer.parseInt(s[1]);
                c = Integer.parseInt(s[2]);
                double m1 = (a + b) / 2;
                if (m1 >= 7)
                    System.out.println("Aprovado");
                else if ((m1 >= 3 && m1 <= 7))
                    System.out.println("Deve fazer N3");
                else if ((m1 + c) / 2 >= 5)
                    System.out.println("Aprovado");
                else
                    System.out.println("Reprovado");
            }
        }
    }
}
