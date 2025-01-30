using System;

public class exercicio_16
{
    // metedo vazio para verificar se e par ou impar
    public static void parImpar(int a)
    {
        bool resultado = a % 2 == 0;
        if (resultado)
        {
            quadrado(a);
        }
        else
        {
            Console.WriteLine("o numero nao e par por isso nao e possivel calcular o quadrado");
        }
    }
    // metedo vazio para calcular o quadrado
    public static void quadrado(int valor)
    {
        int resultado = valor * valor;
       Console.WriteLine("o numero e par e o quadrado é "+ resultado);
    }
    public static void Main(string[] args)
    {
        parImpar(15);
        parImpar(10);
    }
}
