using System;

namespace MatrizSomaMaiorMenor
{
    class Program
    {
        static void Teste()
        {
            Random r = new Random();
            int[,] matriz = new int[4, 4];
            
            int maior = int.MinValue;
            int menor = int.MaxValue;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = r.Next(10); 
                }
            }
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    
                    
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                    }
                    if (matriz[i, j] < menor)
                    {
                        menor = matriz[i, j];
                    }
                }
            }

           
            int soma = maior + menor;

            
            Console.WriteLine($"O maior elemento da matriz é: {maior}");
            Console.WriteLine($"O menor elemento da matriz é: {menor}");
            Console.WriteLine($"A soma do maior com o menor elemento é: {soma}");
        }
    }
}


using System;

namespace SomaDiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[,] matriz = new int[4, 4];
            int somaDiagonal = 0;

            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = r.Next(10); 
                }
            }

            
            for (int i = 0; i < 4; i++)
            {
                somaDiagonal += matriz[i, i];
            }

            
            Console.WriteLine($"A soma dos elementos da diagonal principal é: {somaDiagonal}");
        }
    }
}
