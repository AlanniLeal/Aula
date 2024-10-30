using System;

namespace Exercicio_Revisao
{
    class revisao__
    {
        static void Teste()
        {

            int menor = int.MaxValue;
            int maior = int.MinValue;

        for (int i = 0; i < 10; i++)
        {

         Console.WriteLine("Digite um número: ");
         int numero = int.Parse(Console.ReadLine());

        if (numero < menor)
        menor = numero;
        if (numero > maior)
        maior = numero;
        }


            Console.WriteLine($"O menor número é: {menor}");
             Console.WriteLine($"O maior número é: {maior}");
        }
    }
}