// //1. Faça um programa que calcule a soma dos números de 1 a n, onde n é um número
// //inteiro fornecido pelo usuário.

using System;

namespace Ativ
{
    class Program
    {
    static int SomaNumeros(int n)
    {
        int soma = 0;
        for (int i = 1; i <= n; i++)
        {
                {
                    soma += i;
                }
        }
            return soma;
    }
        
       static void Teste()
        {
             System.Console.WriteLine("Digite um numero:");
             int numero = int.Parse(Console.ReadLine());

            int resultado = SomaNumeros(numero);

            System.Console.WriteLine($"A soma dos numeros de 1 até {numero} é: {resultado}");




        }
    }
        
}







