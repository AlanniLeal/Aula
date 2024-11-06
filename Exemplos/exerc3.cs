using System;

namespace Exercicio_Revisao
{
    class exerc__
    {
        static void Teste()
        {
            System.Console.WriteLine("Informe o tamanho da matriz (n x n): ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];

            System.Console.WriteLine("Preencha a matriz: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] matrizRotacionada = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrizRotacionada[j, n - 1 - i] = matriz[i, j];
                }
            }
            System.Console.WriteLine("Matriz rotacionada:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    System.Console.Write(matrizRotacionada[i, j] + " ");
                }
                System.Console.WriteLine();
            }
        }

    }
}