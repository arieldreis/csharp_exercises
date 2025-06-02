using System;

public class ex010{
    public static void Main(string[] args){
        String[] cores = new String[3];
        cores[0] = "Blue";
        cores[1] = "Red";
        cores[2] = "Green";
        foreach(String cor in cores){
            Console.WriteLine(cor);
        }
    }
}