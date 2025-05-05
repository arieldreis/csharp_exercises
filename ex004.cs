using System;
// VocÊ digita o seu nome e aparece o resultado dele.
public class HelloWorld{
    public static void Main(string[] args){
        String nome;
        Console.WriteLine("Report your name: ");
        nome =  Console.ReadLine();
        Console.WriteLine("My name is: {0}", nome);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(nome);
        Console.ReadKey();
    }
}