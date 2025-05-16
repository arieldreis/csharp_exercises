using System;
// A média simples entre dois números
public class HelloWorld{
    public static void Main(string[] args){
        int numero1 = 0;
        int numero2 = 0;
        int avg = 0;
        Console.WriteLine("Type the first number: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Type the second number: ");
        numero2 = int.Parse(Console.ReadLine());
        avg = (numero1 + numero2) / 2;
        // Imprime os números
        Console.WriteLine("The average is: {0}", avg);
        Console.ReadKey();
    }
}