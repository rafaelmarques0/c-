using System;

public class exemplo_metedo
{ 
     public static void Main(string[] args)
     {
        int resultado = Soma(10,20);

        Console.WriteLine("a soma é: "+resultado);
     }
    // metedo de soma a ser usando//
    static int Soma(int a,int b)
    {
        return a + b;
    }
}
