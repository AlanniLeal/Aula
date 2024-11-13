using System;

namespace Ativ
{
    class Atv3
    {
        static int MDC(int a, int b)
        {
            if (b == 0)
                return a;

            return MDC(b, a % b);


        }

        static void Main()
        {
            System.Console.WriteLine("Digite o primeiro valor");
            int a = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o segundo valor");
            int b = int.Parse(Console.ReadLine());

            int mdc = MDC(a, b);
            System.Console.WriteLine($"O MDC de {a} e {b} é: {mdc}");

        }
    }
}