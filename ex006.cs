using System;
// A multiplicação entre dois números
public class HelloWorld{
    public static void Main(string[] args){
        int numero1 = 0;
        int numero2 = 0;
        int mult = 0;
        Console.WriteLine("Type the first number: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Type the second number: ");
        numero2 = int.Parse(Console.ReadLine());
        mult = numero1 * numero2;
        // Imprime os números
        Console.WriteLine("The multiplication between the numbers {0} x {1} = {2}", numero1, numero2, mult);
        Console.ReadKey();
    }
}