using System;

public class exercicio7
{
    public static void Main(string[] args)
    {
        int nota = 18;

        switch (nota)
        {
            case >= 18 and <= 20:
                Console.WriteLine("excelente");
                break;

            case >= 14 and <= 17:
                Console.WriteLine("bom");
                break;

            case >= 10 and <= 13:
                Console.WriteLine("suficiente");
                break;

            case >= 0 and <= 9:
                Console.WriteLine("insuficiente");
                break;

            default:
                Console.WriteLine("nota inválida");
                break;
        }
    }
}

