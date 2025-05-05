using System;

public class HelloWorld{
    public static void Main(string[] args){
        int numero = 0;
        Console.WriteLine("Digite um Número");
        numero = int.Parse(Console.ReadLine());
        int sucessor = numero + 1;
        int antecessor = numero - 1;
        Console.WriteLine("O sucessor do número é: {0}", sucessor);
        Console.WriteLine("O antecessor do número é: {0}", antecessor);
    }
}