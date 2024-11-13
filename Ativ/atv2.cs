using System;

namespace Ativ
{
    class Atv2
    {
        static int Potencia(int x, int n)
        {
            if (n == 0)
                return 1;

            return x * Potencia(x, n - 1);
        }

        static void Teste()
        {
            System.Console.WriteLine("Digite o valor da base");
            int x = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o valor do expoente");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                System.Console.WriteLine("O expoente não pode ser negativo");
            }
            else
            {
                int resultado = Potencia(x, n);
                System.Console.WriteLine($"{x} elevado a {n} é {resultado}");
            }
        }

    }
}