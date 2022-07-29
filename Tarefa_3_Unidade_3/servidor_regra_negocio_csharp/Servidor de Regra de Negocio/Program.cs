// See https://aka.ms/new-console-template for more information
using Servidor_de_Regra_de_Negocio;
using System.Net;
using System.Net.Sockets;

const int serv_porta = 12345;
const string ip_bd = "127.0.0.1";
const int porta_bd = 12346;

/*Console.WriteLine("Iniciando servidor de regra de negocios.");
Console.WriteLine("Digite o IP do servidor de banco de dados:");
string ip = Console.ReadLine();
Console.Write("Digite a porta do servidor de banco de dados: ");
int porta = int.Parse(Console.ReadLine())
Console.WriteLine($"Servidor BD: {ip_bd}:{porta_bd}");
ClienteBancoDeDados bd = new ClienteBancoDeDados(ip_bd, porta_bd);
string res = bd.BuscarNoBancoDeDados("9$2$45\n");
Console.WriteLine(res);
*/
Console.WriteLine("Iniciando servidor de regra de negocio.");
string ip = PegaIpMaquina();
Console.WriteLine($"IP: {ip} - Porta: {serv_porta}");
ServidorNegocio serv = new ServidorNegocio(serv_porta);
serv.escuta();
static string PegaIpMaquina()
{
    IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
    var ip = host
        .AddressList
        .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
    return $"{ip}";
}
