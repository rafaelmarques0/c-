using System;

public class exercicio_20
{
    public static void Main(string[] args)
    {
        String opcao;
        do
        { //apresenta as opcoes para o utilizador//
            Console.WriteLine("1-conversao de decimal para inteiro");
            Console.WriteLine("2-conversao de numero grande(long) para inteiro");
            Console.WriteLine("3-conversao de caractere(char) para ASCII(int)");
            Console.WriteLine("4-conversao de fora do intervalo do BYTE(0 a 255) para BYTE");
            Console.WriteLine("5-conversao de decimal(double) para float");
            Console.WriteLine("0-sair");

            //le a opcao escolhida pelo utilizador//
            opcao = Console.ReadLine();
            switch (opcao)
            {

                //quando se faz a conversão de um numero decimal para inteiro, pode ser aredondado ou peder informação//
                case "1":
                    //caso 1 converte um numero decimal para inteiro//
                    Console.WriteLine("insira um numero decimal");
                    decimal numeroDecimal = Convert.ToDecimal(Console.ReadLine());
                    int numeroInteiro = Convert.ToInt32(numeroDecimal);
                    Console.WriteLine($"o numero inteiro é: {numeroInteiro}");
                    break;

                //quando se faz a conversão de um numero grande para inteiro, pode perder informação//
                case "2":
                    //caso 2 converte um numero grande para inteiro//
                    Console.WriteLine("insira um numero grande");
                    long numeroGrande = Convert.ToInt64(Console.ReadLine());
                    int numeroInteiro2 = Convert.ToInt32(numeroGrande);
                    Console.WriteLine($"o numero inteiro é: {numeroInteiro2}");
                    break;

                //quando se faz a conversão de um caractere para ASCII, o caractere é convertido para o seu valor ASCII//
                case "3":
                    //caso 3 converte um caractere para ASCII//
                    Console.WriteLine("insira um caractere");
                    char caractere = Convert.ToChar(Console.ReadLine());
                    int ascii = Convert.ToInt32(caractere);
                    Console.WriteLine($"o valor ASCII é: {ascii}");
                    break;

                //quando se faz a conversão de um numero fora do intervalo do BYTE para BYTE ,  //
                //esta errando
                case "4":
                    //caso 4 converte um numero fora do intervalo do BYTE para BYTE//
                    Console.WriteLine("insira um numero fora do intervalo do BYTE");
                    int numeroForaDoIntervalo = Convert.ToInt32(Console.ReadLine());
                    byte numeroByte = Convert.ToByte(numeroForaDoIntervalo);
                    Console.WriteLine($"o numero BYTE é: {numeroByte}");
                    break;

                //quando se faz a conversão de um double para float , perde persisão//
                case "5":
                    //caso 5 converte um double para float //
                    Console.WriteLine("insira um numero decimal");
                    //utilizador insere e converte o numero decimal(double) para float//
                    double numerodecimalparafloat = Convert.ToDouble(Console.ReadLine());
                    double numerofloat = (float)(numerodecimalparafloat);
                    Console.WriteLine($"o numero float é: {numerofloat}");
                    break;

                //caso 0 termina o programa//
                case "0":
                    Console.WriteLine("saido");
                    break;

                default:
                    Console.WriteLine("opção invalida");
                    break;
            }
        } while (opcao != "0");

    }
  }
