using System;


namespace Exercicio_Revisao
{
    class exerc_
    {
        static void Teste()
        {
            System.Console.WriteLine("Informe o tamanho da matriz (n x n): ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int [n, n];
            int SomaDiagonalPrincipal = 0;
            int SomaDiagonalSecundaria = 0;

            System.Console.WriteLine("Preencha a matriz: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                SomaDiagonalPrincipal += matriz[i, i];
                SomaDiagonalSecundaria += matriz[i, n - 1 - i];
            }
                Console.WriteLine($"A soma dos elementos da diagonal principal é: {SomaDiagonalPrincipal}");
                Console.WriteLine($"A soma dos elementos da diagonal principal é: {SomaDiagonalSecundaria}");
        }
    }
}