import org.zeromq.SocketType;
import org.zeromq.ZContext;
import org.zeromq.ZMQ;

public class SubscriberQuestao2 {
    final static String str_bind = "tcp://127.0.0.1:13546";
    public static void main(String[] args){
        try(ZContext con = new ZContext()){
            ZMQ.Socket subs = con.createSocket(SocketType.SUB);
            subs.connect(str_bind);
            subs.subscribe("Questao2".getBytes(ZMQ.CHARSET));
            while (true) {
                // le o topico
                String topico = subs.recvStr();
                // le os dados
                String dados = subs.recvStr();
                String[] s= dados.split("[$]");
                var idade = Integer.parseInt(s[0]);
                var sexo = Integer.parseInt(s[1]);
                if (sexo == 1 && idade > 21)
                    System.out.println("Maioridade Atingida.");
                else if (sexo == 0 && idade >= 18)
                    System.out.println("Maioridade Atingida");
                else
                    System.out.println("Maioridade não Atingida.");
            }
        }
    }
}
