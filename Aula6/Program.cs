using System;

namespace Aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            //matriz tridimencional
            //na tridimencional , 3 indices
            //1 indice: linha
            //2 indice: coluna
            //3 indice: profundidade

            int[,,] matriz3D = new int[2, 2, 2]{
                {
                    {1, 2},
                    {3, 4}
                },

                {
                    {5, 6},
                    {7, 8}
                }

            };

            //percorrendo a matriz
            for (int i = 0; i < matriz3D.GetLength(0); i++)
            {
                for (int j = 0; j < matriz3D.GetLength(1); j++)
                {
                    for (int k = 0; k < matriz3D.GetLength(2); k++)
                    {
                        System.Console.WriteLine($"[{i}, {j}, {k}] = {matriz3D[i, j, k]}");

                    }


                }


            }
            //acessando um elemento da matrizTri
            System.Console.WriteLine(matriz3D[1, 1, 1]);
            System.Console.WriteLine(matriz3D[0, 0, 0]);

            //alterar o valor de um elemento da matrizTri
            matriz3D[1, 1, 1] = 100
                System.Console.WriteLine(matriz3D[1, 1, 1]);

            //somar todos que tem dentro da matrizTri
            int soma = 0;
            for (int i = 0; i < matriz3D.GetLength(0); i++)
            {
                for (int j = 0; j < matriz3D.GetLength(1); j++)
                {
                    for (int k = 0; k < matriz3D.GetLength(2); k++)
                    {
                        soma += matriz3D[i, j, k];

                    }

                }

            }
                //acessar todos os elementos da matrizTri com Foreach
                foreach (int item in matriz3D)
                {
                    System.Console.WriteLine(item);
                }
        }
    }
}