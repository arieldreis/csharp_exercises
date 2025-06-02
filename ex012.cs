using System;

public class ex012{
    public static void Main(string[] args){
        string[] X = new string[3]; // guarda 3 valores
        string[] Y = new string[3]; // guarda outros 3 valores
        string[] R = new string[6]; // vai juntar os dois acima
        for (int i = 0; i < 3; i++){
            Console.Write("Digite o valor de X[{0}]: ", i);
            X[i] = Console.ReadLine();
            Console.Write("Digite o valor de Y[{0}]: ", i);
            Y[i] = Console.ReadLine();
        }
        for (int y = 0; y < 3; y++){
            R[y] = X[y];
        }
        int z = 3;
        for (int i = 0; i < 3; i++){
            R[z] = Y[i];
            z++;
        }
        for (int i = 0; i < 6; i++){
            Console.WriteLine(R[i]);
        }

    }
}