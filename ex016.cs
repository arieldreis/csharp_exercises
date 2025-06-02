using System.Threading.Tasks;

namespace VETOR05{
    public class ex016{
        static void Main(string[] args){
            // criar um vetor para armazenar 10 alunos de um colégio infantil.
            string[] nome = new string[10];
            int[] idade = new int[10];
            char[] sexo = new char[10];

            // ler o vetor de 10 alunos
            for (int i = 0; i < 10; i++){
                Console.Write("Digite o seu nome: ");
                nome[i] = Console.ReadLine();

                Console.Write("Digite a sua idade: ");
                idade[i] = Int32.Parse(Console.ReadLine());

                Console.Write("Digite o seu sexo: ");
                sexo[i] = char.Parse(Console.ReadLine());
            }

            // escrever o vetor de 10 alunos
            for (int i = 0; i < 10; i++){
                Console.Write("O seu nome é: {0} ", nome[i]);
                Console.Write("O sua idade é: {0} ", idade[i]);
                Console.WriteLine("O seu sexo é: {0}", sexo[i]);
            }

            Console.ReadKey();
        }
    }
}
