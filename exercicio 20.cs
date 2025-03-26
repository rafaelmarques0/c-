using System;

public class exercicio_20
{
    public static void Main(string[] args)
    {

                //1 -- quando se faz a conversão de um numero decimal para inteiro, pode ser aredondado ou peder informação//
                
                    //caso 1 converte um numero decimal para inteiro//
                    Console.WriteLine("insira um numero decimal");
                    double numeroDecimal = 2,94
                    int numeroInteiro = Convert.ToInt32(numeroDecimal);
                    Console.WriteLine($"o numero inteiro é: {numeroInteiro}");

                //2 -- quando se faz a conversão de um numero grande para inteiro, pode perder informação/
        
                    //caso 2 converte um numero grande para inteiro//
                    Console.WriteLine("um numero grande para int");
                    long numeroGrande = 1000000
                    int numeroInteiroparaConvert = Convert.ToInt32(numeroGrande);
                    int inteiroCasting = (int)numeroGrande
                    Console.WriteLine($"o numero inteiro em Convert é: {numeroInteiroparaConvert}");
                    Console.WriteLine($"o numero inteiro em Casting é: {inteiroCasting}");
                    
                    

                //3 -- quando se faz a conversão de um caractere para ASCII, o caractere é convertido para o seu valor ASCII//
        
                    //caso 3 converte um caractere para ASCII//
                    Console.WriteLine("insira um caractere");
                    char caractere = 'B'
                    int ascii = Convert.ToInt32(caractere);
                    Console.WriteLine($"o valor ASCII é: {ascii}");
                  

                //4 -- quando se faz a conversão de um numero fora do intervalo do BYTE para BYTE ,
                
                    //caso 4 converte um numero fora do intervalo do BYTE para BYTE//
                    int numeroint = 923
                    byte numerobyteCasting = (byte)numeroint
                    Console.WriteLine($"o numero BYTE é: {numerobyteCasting}");
                    

                //5 -- quando se faz a conversão de um double para float , perde persisão//
                
                    //caso 5 converte um double para float //
                    Console.WriteLine("insira um numero decimal");
                    double numerodecimalparafloat = Convert.ToDouble(Console.ReadLine());
                    double numerofloat = (float)(numerodecimalparafloat);
                    Console.WriteLine($"o numero float é: {numerofloat}");

    }
  }
