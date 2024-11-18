using System;

namespace Exerc1811
{
    class Eexer
    {
        static void Ordernar(int [] vetor)
        {
            int aux;
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length - 1; j++)
                {
                    if (vetor[j] > vetor[j+1])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[j+1];
                        vetor[j+1] = aux;
                    }
                }
            }
        }
        static void Imprimir(int [] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                System.Console.WriteLine(vetor[i] + " ");
            }
            System.Console.WriteLine();
        }
        static void Teste()
        {
            System.Console.WriteLine("Digite os números:");
            string input = Console.ReadLine();
            int[] vetor = Array.ConvertAll(input.Split(' '), int.Parse);
            System.Console.WriteLine("Vetor desordenado");
            Imprimir(vetor);
            Ordernar(vetor);
            System.Console.WriteLine("Vetor ordenado");
            Imprimir(vetor);
        }
    }
}