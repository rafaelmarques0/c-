using System;

public class exercicio15
{
        static void Main(string[] args)
        {
        bool par = Par(10);
        if (par)
        {
            Console.WriteLine("o numero e par");
        }
        else 
        {
            Console.WriteLine("o numero e ímpar");
        }
        }
    public static bool Par (int a)
    {
      return (a%2 == 0);
    }
}
