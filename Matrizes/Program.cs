{
        //formas de declarar uma matriz
        int[,] matriz1 = new int[2,2]; //matriz 2 linhas e 2 colunas 
        int[,] matriz2 = new int[2,2] {
            { 1, 2 }, //linha 0 tem 1 e 2, linha 1 tem 3 e 4
            { 3, 4 } // coluna tem 0 tem 1 e 3, coluna 1 tem 2 e 4
        };
        // //acessando elementos da matriz
        // System.Console.WriteLine(matriz1[0, 0]); //1
        // System.Console.WriteLine(matriz2[0, 1]); //2

        //percorrendo a matriz
        // for (int i = 0; i < matriz2.GetLength(0); i++)
        // {
        //     for (int j = 0; j < matriz2.GetLength(0); j++)
        //     {
        //         System.Console.WriteLine(matriz1[i, j]);

        //     }
        // }
        //somando os elemntos da matriz
        int [,] matrizA = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }

        };
        int [,] matrizB = {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
        };
        int [,] matrizC = new int[3, 3];
        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                Console.Write($"{matrizC[i,j]} ");
            }
            System.Console.WriteLine("");

        }

    }

