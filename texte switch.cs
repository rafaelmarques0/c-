using System;

public class teste
{
        public static void Main(string[] args)
        {
        int dia = 3;
        switch (dia)
        {
            case 1:
                Console.WriteLine("Hoje voce nao tem reuniao marcada");
                break;
            case 2:
                Console.WriteLine("Hoje voce tem reuniao marcada as 2:20 da tarde");
                break;
            case 3:
                Console.WriteLine("Hoje voce tem reuniao marcada ao meio dia");
                break;
            case 4:
                Console.WriteLine("Hoje voce nao tem reuniao marcada");
                Console.WriteLine("aviso de ultima hora voce tera reuniao a 10 da noite");
                break;
            case 5:
                Console.WriteLine("Hoje voce nao tem reuniao marcada");
                break;
            default:
                Console.WriteLine("voce tem reuniao online as 7 da manha");
                break;
        }
    }
}
