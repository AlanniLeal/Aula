using System;

namespace Exerc1811
{
    class Eexer4
    {
        static void Ordernar(int [] vetor)
        {
            int aux, j;
            for (int i = 1; i < vetor.Length; i++)
            {
                aux = vetor[i];
                j = i - 1;
                while (j >= 0 && vetor [j] < aux)
                {
                    vetor[j+1] = vetor [j];
                    j--;
                }
                vetor[j+1] = aux;

            }
        }
       static void Imprimir(int[] vetor)
        {
                foreach (int num in vetor)
            {
                System.Console.WriteLine(num + " ");
            }
            System.Console.WriteLine();
        }
        static void Teste()
        {
            System.Console.WriteLine("Digite os números");
            string input = Console.ReadLine();
            int[] vetor = Array.ConvertAll(input.Split(' '), int.Parse);
            System.Console.WriteLine("Vetor desordenado");
            Imprimir(vetor);
            Ordernar(vetor);
            System.Console.WriteLine("Vetor ordenado em ordem decrescente");
            Imprimir(vetor);
        }
    }
}