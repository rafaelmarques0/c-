using System;
public class exercicio52{
    public static void main(String[] args)
    {
        int idade = 20;
        bool IsAdulto = true;
        if (idade>= 18 && IsAdulto)
        {
            Console.WriteLine("e estudade e alduto");
        }
        else if (idade < 18 && IsAdulto)
        {
            Console.WriteLine(" nao e possivel ser alduto mas sim estudante");
        }
        else {
            Console.WriteLine("e so possivel ser alduto");
        }

    }
}
