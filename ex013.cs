using System;

using System.Threading.Tasks;

namespace VETOR02{
    public class ex013{
        static void Main(string[] args){
            int tamanho = 3;
            int[] A = new int[tamanho];
            int[] B = new int[tamanho];
            int[] R = new int[tamanho];

            for (int i = 0; i < A.Length; i++){
                Console.Write("Digite os elementos de A[{0}]: ", i);
                A[i] = Int32.Parse(Console.ReadLine());

                Console.Write("Digite os elementos de B[{0}]: ", i);
                B[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < R.Length; i++){
                R[i] = A[i] + B[i];
            }

            Console.WriteLine("Valores armazenados no vetor C são: ");
            for (int i = 0; i < R.Length; i++)
{
                Console.WriteLine("R[{0}]: {1}", i, R[i]);
            }

            Console.ReadKey();
        }
    }
}