using System;


namespace Exercicio_Revisao
{
    class exc8
    {
        static void Teste()
        {

            int[] somaLinhas = new int[4];

            {
                int[,] matrizA = new int[4, 4] {
            { 1, 2, 3, 4 },
            { 5, 6, 7 ,8 },
            { 9, 10 , 11, 12 },
            { 13, 14, 15, 16 }
           };

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {


                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {

                        somaLinhas[i] += matrizA[i, j];
                    }
                }
                System.Console.WriteLine("Soma dos elementos das linhas: ");
                for (int i = 0; i < 4; i++)
                {
                    System.Console.WriteLine($"Soma da linha {i + 1}: {somaLinhas[i]}");
                }

            }
        }
    }
}
