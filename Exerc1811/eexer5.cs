using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exerc1811
{
    public class Eexer5
    {

        static void BuubleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }

        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int chave = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > chave)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = chave;
            }
        }

        static void MergeSort(int[] vetor, int inicio, int fim)
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
        static void Main()
        {
            int [] numeros = new int[1000];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = (i % 100) + 1;
            }

            
            int[] bubleArray = (int[])numeros.Clone();
            int[] selectionArray = (int[])numeros.Clone();
            int[] insertionArray = (int[])numeros.Clone();
            int[] mergeArray = (int[])numeros.Clone();

            
            var inicio = DateTime.Now.Ticks; 
            BuubleSort(bubleArray);
            var tempoBubble = DateTime.Now.Ticks - inicio; 

           
            inicio = DateTime.Now.Ticks; 
            SelectionSort(selectionArray);
            var tempoSelection = DateTime.Now.Ticks - inicio; 

           
            inicio = DateTime.Now.Ticks; 
            InsertionSort(insertionArray);
            var tempoInsertion = DateTime.Now.Ticks - inicio; 

            inicio = DateTime.Now.Ticks; 
            MergeSort(mergeArray);
            var tempoMerge = DateTime.Now.Ticks - inicio;



            string melhorAlgoritmo;
            int[] melhorArray;

            if (tempoBubble < tempoSelection && tempoBubble < tempoInsertion)
            {
                melhorAlgoritmo = "BubbleSort";
                melhorArray = bubbleArray;
            }
            else if (tempoSelection < tempoBubble && tempoSelection < tempoInsertion)
            {
                melhorAlgoritmo = "SelectionSort";
                melhorArray = selectionArray;
            }
            else
            {
                melhorAlgoritmo = "InsertionSort";
                melhorArray = insertionArray;
            }
            else
            {
                melhorAlgoritmo = "MergeSort";
                melhorArray = mergeArray;
            }

          
            Console.WriteLine($"Tempo de execução do BubbleSort: {tempoBubble}");
            Console.WriteLine($"Tempo de execução do SelectionSort: {tempoSelection}");
            Console.WriteLine($"Tempo de execução do InsertionSort: {tempoInsertion}");
            System.Console.WriteLine($"Tempo de execução do MergeSort: {tempoMerge}");
            Console.WriteLine($"O melhor algoritmo foi o {melhorAlgoritmo}");
        }
    }
}