using System;

public class HelloWorld{
    public static void Main(string[] args){
        int numero1 = 0;
        int numero2 = 0;
        Console.WriteLine("Type the first number: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Type the second number: ");
        numero2 = int.Parse(Console.ReadLine());
        // Imprime os números
        Console.WriteLine("You type the numbers: {0} and {1}", numero1, numero2);
        Console.ReadKey();
    }
}