
using System;

public class exercicio11 { 
       public static void Main(string[] args)
        {
        int soma = 0;
        int contador = 0;
        do
        {
            soma += contador;
            Console.WriteLine(soma);
            contador++;
        }
        while (soma <= 100);
    }
}