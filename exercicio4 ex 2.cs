﻿using System;
public class exercicio4Ex2
{
 public static void Main(string[] args)
 {//exercicio 2\\
   int soma = 0;
   for (int contador = 1; contador <= 50; contador++) {
   if (contador%2 != 0) {
   soma = soma + contador;}
   }
   Console.WriteLine("total de numeros impares="+soma);
 }
}