import org.zeromq.SocketType;
import org.zeromq.ZContext;
import org.zeromq.ZMQ;
import org.zeromq.ZMQ.Socket;


public class SubscriberQuestao1 {
    final static String str_bind = "tcp://127.0.0.1:13546";
    public static void main(String[] args){
        try(ZContext con = new ZContext()){
            Socket subs = con.createSocket(SocketType.SUB);
            subs.connect(str_bind);
            subs.subscribe("Questao1".getBytes(ZMQ.CHARSET));
            while (true) {
                // le o topico
                String topico = subs.recvStr();
                // le os dados
                String dados = subs.recvStr();
                String[] s= dados.split("[$]");
                double sal = 0;
                if(s.length > 0){
                    sal = Double.parseDouble(s[2]);
                    if(s[1].compareTo("Operador") == 0){
                        sal *= 1.2;
                    }else{
                        sal *= 1.18;
                    }
                    System.out.println("O novo salario de " + s[0] + " e de: " + sal);
                }
            }
        }
    }
}