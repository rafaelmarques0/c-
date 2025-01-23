using System;


public class exercicio14
{  
        static void Main(string[] args)
        {
        int numero = Soma(30, 20);
        Console.WriteLine("o numero maior é: "+numero);
        }
    static int Soma (int a,int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}
