using System;

namespace Atividades_
{
    class Ativ2
    {
        static bool ePalindromo(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] != vetor[vetor.Length - 1 - i])
                    return false;
            }

            return true;
        }
        static void Teste()
        {
        int[] vetor = { 1, 2, 3, 4, 5 }; //ou { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
        
        if (ePalindromo(vetor))
            {
                Console.WriteLine("O vetor é um palíndromo.");
            }
            else
            {
                Console.WriteLine("O vetor não é um palíndromo.");
            }

        }

    }
}