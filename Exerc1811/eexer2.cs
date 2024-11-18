using System;

namespace Exerc1811
{
    class Eexer2
    {
        static void Ordernar(int [] vetor, out int interacoes)
        {
            int aux;
            interacoes = 0;
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
                    interacoes++;
                }
            }
        }
        static void Imprimir(int [] vetor)
        {
            foreach (int num in vetor)
            {
                System.Console.WriteLine(num + " ");
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
            int interacoes;
            Ordernar(vetor, out interacoes);
            System.Console.WriteLine("Vetor ordenado");
            Imprimir(vetor);
           
            System.Console.WriteLine($"Número de interações usadas: {interacoes} ");
        }
    }
}