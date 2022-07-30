import org.zeromq.SocketType;
import org.zeromq.ZContext;
import org.zeromq.ZMQ;

public class SubscriberQuestao4 {
    final static String str_bind = "tcp://127.0.0.1:13546";
    public static void main(String[] args){
        try(ZContext con = new ZContext()){
            ZMQ.Socket subs = con.createSocket(SocketType.SUB);
            subs.connect(str_bind);
            subs.subscribe("Questao4".getBytes(ZMQ.CHARSET));
            while (true) {
                // le o topico
                String topico = subs.recvStr();
                // le os dados
                String dados = subs.recvStr();
                String[] d= dados.split("[$]");

                int sexo = Integer.parseInt(d[0]);
                double altura = Double.parseDouble(d[1]);
                double peso = 0;
                if (sexo == 1)
                    peso = ((72.7 * altura) - 58);
                else if (sexo == 0)
                    peso = (62.1 * altura - 44.7);
                else
                    System.out.println("Peso errado enviado.");
                System.out.println(String.format("O peso ideal e: %f.", peso));
            }
        }
    }
}
