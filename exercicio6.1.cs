using System;
public class ex6 { 
    static void Main(string[] args)
    {
        int nota = 80;
        switch(nota)
        {
            case int n when (n >= 90):
                Console.WriteLine("classificaçao final = A ");
                break;
            case int n when (n >= 80):
                Console.WriteLine("classificaçao final = B ");
                break;
            case int n when (n >= 70):
                Console.WriteLine("classificaçao final = C ");
                break;
            case int n when (n >= 60):
                Console.WriteLine("classificaçao final = D ");
                break;
            case int n when (n <50):
                Console.WriteLine("classificaçao final = F ");
                Console.WriteLine("nao passantes de ano");
                break;
            default:
                Console.WriteLine("nota nao ativuida");
                break;
        }
    }
 }

