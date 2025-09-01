using System;
public class ex009
{
    public static void Main(string[] args)
    {
        string nome;
        // variavel que armazena o nome
        Console.Write("Informe o seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Meu nome é: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(nome);
        Console.ReadKey();
    } 
}