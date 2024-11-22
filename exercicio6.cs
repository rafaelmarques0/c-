using System; 
public class ex6 {

    static void Main(string[] args)
    {
        int dia = 8;
        switch(dia)
        {
            //segunda\\
            case 1 :
                dia = 1;
                Console.WriteLine("hoje e segunda-feira");
            break;
                //terca\\
            case 2 :
                dia = 2;
                Console.WriteLine("hoje e terca-feira");
                break;
                //quarta
            case 3:
                dia = 3;
                Console.WriteLine("hoje e quarta-feira");
                break;
                //quinta\\
            case 4:
                dia = 4;
                Console.WriteLine("hoje e quinta-feira");
                break;
                //sexta-feira\\
                 case 5:
                dia = 5;
                Console.WriteLine("hoje e sexta-feira");
                break;
                // feirado ou fim de semana\\
            default:
                Console.WriteLine("entao hoje e fim de semana ou feriado");
                break ;
        }
    }
}