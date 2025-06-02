using System;
// Programa onde vocÊ digita dois números
public class ex015{
    public static void Main(string[] args){
        // Criar um vetor para armazenar sete valores de temperatura
        // declaração do vetor
        int[] temp = new int[7];
        for(int cont = 1; cont < 8; cont++){
            Console.Write("Digite a temperatura {0}: ", cont);
            temp[cont] = Int32.Parse(Console.ReadLine());
        }
        // Escrever o vetor na tela
         for(int cont = 1; cont < 8; cont++){
            Console.Write(temp[cont]);
        }
    }
}