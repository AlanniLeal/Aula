using System;

namespace Atividades
{
    class Ativ
    {
        public delegate int Operacao(int[,] Matriz);
        static int somaMatriz(int[,] matriz)
        {
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i, j];
                }
            }
             return soma;
        }
        static void Teste()

        {
            int[,] matriz = new int[4, 4] {
                { 1, 2, 3, 4 },
                { 5, 6, 7 ,8 },
                { 9, 10 , 11, 12 },
                { 13, 14, 15, 16 }
           };

            Operacao operacao = somaMatriz;

            int resultado = operacao(matriz);
            System.Console.WriteLine("O resultado da soma das linhas da matriz é: {0}", resultado);

        }
    }
}