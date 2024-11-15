using System;
public class exercicio53
{
    static void Main(string[] args)
    {
        int idade = 15;
        bool isCasado = true;

        if (idade >= 65)
        {
            Console.WriteLine("Es senior");
        }
        else if ( idade >= 18   && isCasado)
        {
            Console.WriteLine("Es alduto e casado ");
        }
        else if (idade > 18  && !isCasado ){
            Console.WriteLine("es alduto e solteiro");
        }
        else
        {
            Console.WriteLine("Es menor de idade ");
        }
    }
}

