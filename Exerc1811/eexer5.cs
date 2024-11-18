using System;

namespace Aula10
{
    class Eexer5
    {
        static void BubbleSort(int [] vetor)
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
         static void SelectionSort(int[] vetor)
        {
            int menor, aux;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                menor = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[menor])
                    {
                        menor = j;
                    }
                }
                aux = vetor[i];
                vetor[i] = vetor[menor];
                vetor[menor] = aux;
            }
        }
        static void InsertionSort(int[] vetor)
        {
            int aux, j;
            for (int i = 1; i < vetor.Length; i++)
            {
                aux = vetor[i];
                j = i - 1;
                while (j >= 0 && vetor[j] > aux) {
                    vetor[j+1] = vetor [j];
                    j--;
                }
                vetor[j+1] = aux;
            }
        }
        
    }
}