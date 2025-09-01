using System.Text;
using System.Threading.Tasks;
public class ex011{
    public static void Main(string[] args){
        int total = 5;
        int[] tick = new int[total];
        String[] nome = new String[total];
        for(int cont = 0; cont < total; cont++){
            Console.WriteLine("Digite o Ticket: ");
            tick[cont] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o passageiro: ");
            nome[cont] = Console.ReadLine();
        }
    }
}