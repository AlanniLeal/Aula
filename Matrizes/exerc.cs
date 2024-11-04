using System;

namespace Aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}