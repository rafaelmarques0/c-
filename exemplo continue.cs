using System;

public class exemploContinue
{
        public  static void Main(string[] args)
        {
            for (int contador = 1; contador <= 10; contador++)
            {
             
                if (contador == 5)
                {
                    continue;
                }
            Console.WriteLine(contador);
        }
        }  
}
