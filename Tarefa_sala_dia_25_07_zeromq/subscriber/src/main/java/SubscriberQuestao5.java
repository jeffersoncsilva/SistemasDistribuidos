import org.zeromq.SocketType;
import org.zeromq.ZContext;
import org.zeromq.ZMQ;

public class SubscriberQuestao5 {
    final static String str_bind = "tcp://127.0.0.1:13546";
    public static void main(String[] args){
        try(ZContext con = new ZContext()){
            ZMQ.Socket subs = con.createSocket(SocketType.SUB);
            subs.connect(str_bind);
            subs.subscribe("Questao5".getBytes(ZMQ.CHARSET));
            while (true) {
                // le o topico
                String topico = subs.recvStr();
                // le os dados
                String dados = subs.recvStr();
                String[] d= dados.split("[$]");
                int idade = Integer.parseInt(d[0]);
                String res = "";
                if (idade < 5)
                    res= "Muito novo para possuir categoria.";
                else if (idade >= 5 && idade <= 7)
                    res= "Categoria infantil A";
                else if (idade >= 8 && idade <= 10)
                    res= "Categoria infantil B";
                else if (idade >= 11 && idade <= 13)
                    res= "Categoria juvenil A";
                else if (idade >= 14 && idade <= 17)
                    res= "Categoria juvenil B";
                else if (idade >= 18)
                    res= "Categoria Adulto";
                System.out.println(res);
            }
        }
    }
}
