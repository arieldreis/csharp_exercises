using System.Threading.Tasks;

namespace VETOR03{
    public class ex014{
        /* 
        * Escrever um algoritmo que lê um vetor N[10] e o escreve. 
        * Encontre, a seguir, o menor elemento e a sua posição no vetor N e escreva...
        * "O menor elemento de N é = ... e sua posição é ..."
        */

        static void Main(string[] args){
            int[] N = new int[10];
            int menorValor = int.MaxValue;
            int menorPosicao = int.MaxValue;
            for (int i = 0; i < N.Length; i++){
                Console.Write("Digite o elemento {0} do vetor N: ", i);
                N[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N.Length; i++){
                if (N[i] < menorValor){
                    menorValor = N[i];
                    menorPosicao = i;
                }
            }
            Console.WriteLine("O menor elemento de N é = {0} e a sua posição é {1}", menorValor, menorPosicao);
            Console.ReadKey();
        }
    }
}
