using System;

public class Exercicio_18
{
      public static void Main(string[] args)
      {
        //Array das Cidades//
        String[] Cidades = { "Lisboa", "Porto", "Coimbra", "Faro", "Braga" };
        
        //Array da populaçao//
        int[] populacao = { 545000, 237000, 143000, 118000, 193000 };
        


        // fazeer lista de cidades e a sua populacao//
        Console.WriteLine("Cidades e as suas população");
        for (int contador= 0; contador < Cidades.Length; contador++)
        {
            Console.WriteLine($"{Cidades[contador]} - {populacao[contador]} Habitantes");
        }
      }
}
