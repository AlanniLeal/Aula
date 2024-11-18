using System;

namespace Aula10
{
    class SelectSort
    {
        //função de ordenação usando Select Sort
        static void Ordernar(int[] vetor)
        {
            int maior, aux;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                maior = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] > vetor[maior])
                    {
                        maior = j;
                    }
                }
                aux = vetor[i];
                vetor[i] = vetor[maior];
                vetor[maior] = aux;
            }
        }
        static void Imprimir(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                System.Console.WriteLine(vetor[i] + " ");
            }
            System.Console.WriteLine();
        }
        static void Teste()
        {
             int[] vetor = {3, 1, 5, 7, 3, 4, 8, 5};
            System.Console.WriteLine("Vetor desordenado");
            Imprimir(vetor);
            Ordernar(vetor);
            System.Console.WriteLine("Vetor ordenado");
            Imprimir(vetor);
        }
    }
}