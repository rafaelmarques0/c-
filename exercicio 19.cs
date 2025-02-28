using System;
using System.Collections.Generic;

public class exercicio19

{
    public static void Main(string[] args)
    {
        
        //cria um dicionario
        Dictionary<string, String> contactos = new Dictionary<string, String>();

            //mosta as opcões para o utilizador
            Console.WriteLine("seleciona a opção");
        Console.WriteLine("1 - Adicionar contacto");
        Console.WriteLine("2 - Pesquisar contactos");
        Console.WriteLine("3 - remover contactos");
        Console.WriteLine("4 - Sair");

        //varialvel para guardar a opção do utilizador
        String opcao = Console.ReadLine();

        //verifica a opção escolhida pelo utilizador
        do {

        switch (opcao)
        {

            //opção para adicionar um contacto
            case "1":
                // pergunta o nome do contacto e aguarada
                Console.WriteLine("Introduza o nome do contacto");
                String nome = Console.ReadLine();

                    // aguara o numero do contacto
                    Console.WriteLine("Introduza o numero do contacto");
                String telefone = Console.ReadLine();

                //adiciona o contacto ao dicionario
                contactos.Add(nome,telefone);
                 
                Console.WriteLine("Contacto adicionado com sucesso");

                break;

            // opção para pesquisar um contacto
            case "2":

                Console.WriteLine("Introduza o nome do contacto");

                //pergunta o nome do contacto
                string nome1 = Console.ReadLine();

                //verifica se o contacto existe
                if (contactos.ContainsKey(nome1))
                {
                    Console.WriteLine("O contacto " + nome1 + " existe");
                    Console.WriteLine("nome: "+ nome1 +" numero: " + contactos[nome1]);
                }
                else
                {
                    Console.WriteLine("O contacto " + nome1 + " não existe");
                }

                break;

            // opção para adicionar varioa contactos
            case "3":
                // pergunta o nome do contacto e aguarada
                Console.WriteLine("Introduza o nome do contacto");
                String nome3 = Console.ReadLine();

                // verifica se o contacto existe
                if (contactos.ContainsKey(nome3))
                {
                   contactos.Remove(nome3);
                    Console.WriteLine("O contacto eliminado com sucesso");
                }
                else
                {
                    Console.WriteLine("O contacto ja eliminado ao nao existe");
                }
  

                break;

            //opção de  sai do programa
            case "4":

                Console.WriteLine("saindo do programa");

                break;

            // caso o utilizador escolha uma opção que não existe
            default:

                Console.WriteLine("opção invalinda ");

                break;
        }
    } while (opcao != "4");
    }
}