using System;

namespace Aula7
{

    public class Program
    {
         static int soma(int a, int b)
        {
            return a + b;
        }
         static void imprimir(string texto)
         {
            System.Console.WriteLine(texto);
         }   

         static double multiplicacao(double a, double b, double c)
         {
            return a * b * c;
         }

        static double multiplicacao2(double a = 10, double b = 20, double c = 30)
         {
            return a * b * c;
         }

         static int somaVetor(int[] vetor)
         {
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }
            return soma;
         }

        // static int somaMatriz(int[,] matriz)
        {
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i, j];
                }
            }
        }
        static void Teste()
        {
            int a = 10;
            int b = 20;
            int resultado = soma(a, b);
            // System.Console.WriteLine("A soma de {0} e {1} e a soma deles é {2}", a, b resultado);
            // imprimir("Olá Mundo")

            double x = 10;
            double y = 20;
            double z = 30;

            // double resultado2 = multiplicacao(x, y, z);
            // System.Console.WriteLine("O resultado da multiplicação é: {0}", resultado2);

            // double resultado3 = multiplicacao2(2, 5);
            // System.Console.WriteLine("O resultado da multiplicação é: {0}", resultado3);

            // int[] vetor = {1, 2, 3, 4, 5 };
            // int resultado4 = somaVetor(vetor);
            // System.Console.WriteLine("O resultado da soma do vetor é: {0}", resultado4);
            
            int[,] matriz = { { 1, 2, 3}, { 4, 5, 6} };
            int resultado5 = somaMatriz(matriz);
            System.Console.WriteLine("O resultado da soma da matriz é: {0}", resultado5);
        }
  
  
  
    }
}
