using System;


namespace Exercicio_Revisao
{
    class exerc
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10] {1,2,3,4,5,6,7,8,9,10};
            
            bool ePalindromo = false;
            int[] vetorInverso = new int[10];

            for (int i = 9; i >= vetor.Length;i++)
            {
                 vetorInverso[i] = vetor[vetor.Length - 1 - i];
                 System.Console.WriteLine(vetorInverso[i]);
                
            }           
           
            // for (int i = 0; i < 10; i++)
            // {
            //     if (vetor == vetorInverso)
            //    {
            //         ePalindromo = true;

            //    } 
            //    else {
            //     ePalindromo = false;
            //     break;
            //    }
            // }
            //  if (ePalindromo)
            // {
            //     Console.WriteLine("O vetor é um palíndromo.");
            // }
            // else
            // {
            //     Console.WriteLine("O vetor não é um palíndromo.");
            // }

        }
    }
}

            