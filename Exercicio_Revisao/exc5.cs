
{
    int[,] matrizA = {
            { 1, 2, 3, 4 },
            { 5, 6, 7 ,8 },
            { 9, 10 , 11, 12 }

        };
    int[,] matrizB = {
            { 9, 10 , 11, 12 },
            { 5, 6, 7 ,8 },
            { 1, 2, 3, 4 }
        };
    int[,] matrizC = new int[4, 4];
    for (int i = 0; i < matrizA.GetLength(0); i++)
    {
        for (int j = 0; j < matrizA.GetLength(1); j++)
        {
            matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
            Console.Write($"{matrizC[i, j]} ");
        }
        System.Console.WriteLine("");

    }
}



{
    int[,] matrizA = {
            { 1, 2, 3, 4 },
            { 5, 6, 7 ,8 },
            { 9, 10 , 11, 12 }

        };
    int[,] matrizB = {
            { 9, 10 , 11, 12 },
            { 5, 6, 7 ,8 },
            { 1, 2, 3, 4 }
        };
    int[,] matrizC = new int[4, 4];
    for (int i = 0; i < matrizA.GetLength(0); i++)
    {
        for (int j = 0; j < matrizA.GetLength(1); j++)
        {
            matrizC[i, j] = matrizA[i, j] * matrizB[i, j];
            Console.Write($"{matrizC[i, j]} ");
        }
        System.Console.WriteLine("");

    }
}



    


