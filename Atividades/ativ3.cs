using System;

namespace Atividades2
{
    class Ativ3
    {
        public static void SomaDiagonais(int[,] matriz, out int somaDiagonalPrincipal, out int somaDiagonalSecundaria)
        {
            somaDiagonalPrincipal = 0;
            somaDiagonalSecundaria = 0;
            int n = matriz.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                somaDiagonalPrincipal += matriz[i, i];
                somaDiagonalSecundaria += matriz[i, n - 1 - i];

            }
        }
        static void Teste()

        {
            int[,] matriz = new int[4, 4] {
                { 1, 2, 3, 4 },
                { 5, 6, 7 ,8 },
                { 9, 10 , 11, 12 },
                { 13, 14, 15, 16 }
           };
        
                int somaDiagonalPrincipal, somaDiagonalSecundaria;

                SomaDiagonais(matriz, out somaDiagonalPrincipal, out somaDiagonalSecundaria);

                Console.WriteLine($"A soma dos elementos da diagonal principal é: {somaDiagonalPrincipal}");
                Console.WriteLine($"A soma dos elementos da diagonal principal é: {somaDiagonalSecundaria}");
        }
}
}



