using System;

namespace Aula10
{
    class InsertionSort
    {
        static void Ordernar(int [] vetor)
        {
            int aux, j;
            for (int i = 0; i < vetor.Length; i++)
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
             {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " "); 
            }
            Console.WriteLine(); 
        }
        }
        static void Main(string [] args)
        {
            System.Console.WriteLine("Digite os números");
            string input = Console.ReadLine();
            System.Console.WriteLine("Vetor desordenado");
            Imprimir(vetor);
            Ordernar(vetor);
            System.Console.WriteLine("Vetor ordenado em ordem decrescente");
            Imprimir(vetor);
        }
    }
}