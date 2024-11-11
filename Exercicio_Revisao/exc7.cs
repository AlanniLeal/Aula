using System;

namespace Exercicio_Revisao
{
    class exc7
    {
        static void Teste()
        {
            double[] numeros = new double[10];
            double soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número: ");

                numeros[i] = Convert.ToDouble(Console.ReadLine());
                soma += numeros[i];
            }
                    double media = soma / numeros.Length;

                    System.Console.WriteLine($"A média dos valores é: {media}");
                    
           
            
        }
    }
}
