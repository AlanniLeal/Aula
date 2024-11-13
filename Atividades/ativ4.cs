using System;

namespace Atividade
{
    class Ativ4
    {
        private int[,] matrizRotacionada(int[,] matriz)
        {
             int[,] matrizRotacionada = new int[matriz.GetLength(0), matriz.GetLength(1)];

            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matrizRotacionada[j, matriz.GetLength(0) - 1 - i] = matriz[i, j];
                }
            }

            return matrizRotacionada;
        }

        public void printMatriz(int[,] matriz)
        {
            Console.WriteLine("Matriz Rotacionada:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Teste()
        {
           
            int[,] matriz = new int[3, 3] {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            Ativ4 op = new Ativ4();
            int[,] matrizRotacionada = new int[3, 3];
            matrizRotacionada = op.matrizRotacionada(matriz);
            op.printMatriz(matrizRotacionada);
            

        }
    }

}

    
            


