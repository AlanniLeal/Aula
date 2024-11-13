// Faça um programa que calcule a soma dos elementos de um vetor de inteiros
using System;

namespace Ativ_
{
    class Atv4
    {
    static int  SomaElementos (int [] vetor, int indice)
    {
        if (indice == vetor.Length)
            return 0;
        return vetor[indice] + SomaElementos(vetor, indice + 1);

    }

      static void Teste()
        {
            int[] vetor = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            int soma = SomaElementos(vetor, 0);

            System.Console.WriteLine($"A soma dos elementos do vetor é: {soma}");
       }
   }
}