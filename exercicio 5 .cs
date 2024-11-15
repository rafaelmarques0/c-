using System;
public class exercicio5
{
    public static void Main(string[] args)
    {
        //idade\\
        int idade = 20;
        //variaveis\\
        if (idade < 12)
        {
            Console.WriteLine("e criança");
        }
        else if (idade >=12 && idade < 18)
        {
            Console.WriteLine("e adolecente");
        }
        else
        {
            Console.WriteLine("e adulto");
        }
    }
}