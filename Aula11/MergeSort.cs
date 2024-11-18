using System;

namespace Aula11
{
    public class MergeSort
    {
        static void Ordernar(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int meio = (inicio + fim) / 2;
                Ordernar(vetor, inicio, meio);
                Ordernar(vetor, meio + 1, fim);
                Intercalar(vetor, inicio, meio, fim);
            }
        }
        static void Intercalar(int[] vetor, int inicio, int meio, int fim)
        {
            int[] aux = new int[vetor.Length];
            for (int j = inicio; j <= fim; j++)
            {
                aux[j] = vetor[j];
            }
            int i1 = inicio;
            int i2 = meio + 1;
            int i3 = inicio;

            while (i1 <= meio && i2 <= fim)
            {
                if (aux[i1] < aux[i2])
                {
                    vetor[i3] = aux[i1];
                    i1++;
                }
                else
                {
                    vetor [i3] = aux[i2];
                    i2++;
                }
                i3++;
            }
            while (i1 <= meio)
            {
                vetor[i3] = aux[i1];
                i1++;
                i3++;
            
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
            int[] vetor = {3, 1, 5, 7, 3, 4, 9, 2};
            System.Console.WriteLine("Vetor desordenado");
            Imprimir(vetor);
            Ordernar(vetor, 0, vetor.Length-1);
            System.Console.WriteLine("Vetor ordenado");
            Imprimir(vetor);
        }
    }
}