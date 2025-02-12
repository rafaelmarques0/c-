using System;
public class Exercicio_17
{
    
      public static void Main(string[] args)
      {
        //Arrays //
        String[] ListaFilmes = {"Transformers", "Sherk 2","Tictanic" };
        int[] DatasFilmes = { 2008, 2010, 2000 };

        //faz uma list com o For e Arrays//
        Console.WriteLine("listas de Filmes: ");
        for (int contador = 0; contador < ListaFilmes.Length; contador++)
        {
                Console.WriteLine(ListaFilmes[contador]+" - " + DatasFilmes[contador]); 
             
        }

    }
}
