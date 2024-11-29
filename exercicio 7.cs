using System;

public class exercicio7 { 
        static void Main(string[] args)
        {int nota = 29;
        switch(nota)
        {
            case int n when (n >= 17):
                Console.WriteLine("excelente");
                break;

            case int n when (n >= 14):
                Console.WriteLine("bom");
                break;

            case int n when (n >= 10):
                Console.WriteLine("suficiente");
                break;

            case int n when (n >= 0):
                Console.WriteLine("insuficiente");
                break;

                default:
                Console.WriteLine("nota inválida");
                break ;
        }
        }
    }

