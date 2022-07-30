import org.zeromq.SocketType;
import org.zeromq.ZContext;
import org.zeromq.ZMQ;

public class SubscriberQuestao6 {
    final static String str_bind = "tcp://127.0.0.1:13546";
    public static void main(String[] args){
        try(ZContext con = new ZContext()){
            ZMQ.Socket subs = con.createSocket(SocketType.SUB);
            subs.connect(str_bind);
            subs.subscribe("Questao6".getBytes(ZMQ.CHARSET));
            while (true) {
                // le o topico
                String topico = subs.recvStr();
                // le os dados
                String d = subs.recvStr();
                String[] dados= d.split("[$]");

                double salario = Double.parseDouble(dados[0]);
                int dependentes = Integer.parseInt(dados[1]);
                char nivel = dados[2].charAt(0);
                double salarioReajustado = 0;
                switch (nivel)
                {
                    case 'A':
                        salarioReajustado = (dependentes == 0) ? salario * 0.97 : salario * 0.92;
                        break;
                    case 'B':
                        salarioReajustado = (dependentes == 0) ? salario * 0.95 : salario * 0.8;
                        break;
                    case 'C':
                        salarioReajustado = (dependentes == 0) ? salario * 0.92 : salario * 0.85;
                        break;
                    case 'D':
                        salarioReajustado = (dependentes == 0) ? salario * 0.9 : salario * 0.83;
                        break;
                }
                System.out.println(String.format("O senhor %s tem um salario de R$ %f e pertence ao nivel %c.", dados[0], salarioReajustado, nivel));
            }
        }
    }
}
