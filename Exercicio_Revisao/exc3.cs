// Reescreva o programa que identifica o DDD dos estados, utilizando a estrutura Caso,
// de acordo com os seguintes critérios de DDDs e seus respectivos Estados brasileiros.
// • Paraná: 41, 42, 43, 44, 45 e 46
// • Rio Grande do Sul: 51, 53, 54 e 55
// • Brasília: 61
// • Goiás: 62 e 64
// • Mato Grosso: 65 e 66
// • Mato Grosso do Sul: 67


using System;

namespace Exercicio_Revisao
{
    class revisao_
    {
        static void Teste()
        {
            System.Console.WriteLine("Informe seu DDD");
            int DDD =  int.Parse(System.Console.ReadLine());
            switch (DDD)
            {
                case int n when n >= 41 && n<=46: 
                    Console.WriteLine($"Paraná");
                    break;
                case int n when (n >= 53 && n <= 55) || n == 51: 
                    Console.WriteLine($"Rio Grande do Sul");
                    break;
                case int n when n ==61: 
                    Console.WriteLine($"Brasília");
                    break;
                case int n when n == 62 || n == 64: 
                    Console.WriteLine($"Goiás");
                    break;
                case int n when n == 65 || n == 66: 
                    Console.WriteLine($"Mato Grosso");
                    break;
                case int n when n == 67: 
                    Console.WriteLine($"Mato Grosso do Sul");
                    break;
                default:
                    System.Console.WriteLine("DDD não está na lista");
                    break;
            }
            



        }
    }
}