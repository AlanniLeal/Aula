using System;


namespace Exercicio_Revisao
{
    class exerc
    {
        static void Teste()
        {
            int[] vetor = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            bool ePalindromo = true;
            int[] vetorInverso = [vetor.Length];

            for (int i = 0; i >= vetor.Length; i++)
            {
                vetorInverso[i] = vetor[vetor.Length - 1 - i];


            }

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] != vetorInverso[i])
                {
                    ePalindromo = false;
                    break;
                }
            }

        }
             if (ePalindromo)
            {
                Console.WriteLine("O vetor é um palíndromo.");
            }
            else
            {
                Console.WriteLine("O vetor não é um palíndromo.");
            }

        }
    }


            