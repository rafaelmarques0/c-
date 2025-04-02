using System;
using System.Collections.Generic;
public class exercicio_21
{
    public static void Main(string[] args)
    {

        //cria um dicionario
        Dictionary<String, int> contactos = new Dictionary<String, int>();

        String opcao;
        do
        { //mosta as opcões para o utilizador
            Console.WriteLine("seleciona a opção");
            Console.WriteLine("1 - Adicionar contacto");
            Console.WriteLine("2 - Pesquisar contactos");
            Console.WriteLine("3 - remover contactos");
            Console.WriteLine("4 - Sair");

            //varialvel para guardar a opção do utilizador
            opcao = Console.ReadLine();

            //verifica a opção escolhida pelo utilizador

            switch (opcao)
            {

                //opção para adicionar um contacto
                case "1":

                    // pergunta o nome do contacto e aguarada
                    Console.WriteLine("Introduza o nome do contacto");
                    String nome = Console.ReadLine();

                    // aguara o numero do contacto
                    Console.WriteLine("Introduza o numero do contacto");
                    String telefone = Console.ReadLine(telefone);
                    Convert.ToInt32(telefone)

                    //adiciona o contacto ao dicionario
                    contactos.Add(nome, telefone);

                    Console.WriteLine("Contacto adicionado com sucesso");

                    break;

                // opção para pesquisar um contacto
                case "2":
                    contactos.Add("joao", 123456789);
                    Console.WriteLine("Introduza o nome do contacto");

                    //pergunta o nome do contacto
                    string nomepesquisado = Console.ReadLine();

                    //verifica se o contacto existe
                    if (contactos.ContainsKey(nomepesquisado))
                    {
                        Console.WriteLine($"O contacto {nomepesquisado}, existe");
                        Console.WriteLine($"nome: {nomepesquisado} \nnumero: {contactos[nomepesquisado]}");
                    }
                    else
                    {
                        Console.WriteLine($"O contacto {nomepesquisado}, não existe");
                    }

                    break;

                // opção para adicionar varioa contactos
                case "3":
                    // pergunta o nome do contacto e aguarada
                    Console.WriteLine("Introduza o nome do contacto");
                    nomepesquisado = Console.ReadLine();

                    // verifica se o contacto existe
                    if (contactos.ContainsKey(nomepesquisado))
                    {
                        contactos.Remove(nomepesquisado);
                        Console.WriteLine("O contacto eliminado com sucesso");
                    }
                    else
                    {
                        Console.WriteLine("O contacto ja eliminado ao nao existe");
                    }

                    break;

                //opção de  sai do programa
                case "4":

                    Console.WriteLine("saindo do programa...");

                    break;

                // caso o utilizador escolha uma opção que não existe
                default:

                    Console.WriteLine("opção invalida ");

                    break;
            }

        } while (opcao != "4");
    }
}