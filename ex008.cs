namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            double Salario;

            Console.WriteLine("Informe o seu salário");
            Console.WriteLine();
            Console.Write("Salário: ");
            double.TryParse(Console.ReadLine(), out Salario);
            Console.WriteLine();

            Console.Write("Salário atual: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Salario.ToString());
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("(-)");

            Console.Write("Novo salário: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(p.CalculaSalario(Salario));
            Console.ReadKey();
        }

        private double CalculaSalario(double Salario)
        {
            double NovoSalario = 0;

            if (Salario >= 1700)
            {
                NovoSalario = (Salario + 200);
            }
            else
            {
                NovoSalario = (Salario + 300);
            }

            return NovoSalario;
        }
    }
}