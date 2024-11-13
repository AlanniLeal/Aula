using System;

namespace Ativ
{
    class Atv
    {
    static int ProdutoNumeros(int n)
    {
        int produto = 1;
        for (int i = 1; i <= n; i++)
        {
                {
                    produto *= i;
                }
        }
            return produto;
    }
        
       static void Teste()
        {
             System.Console.WriteLine("Digite um numero:");
             int numero = int.Parse(Console.ReadLine());

            int resultado = ProdutoNumeros(numero);

            System.Console.WriteLine($"O produto dos numeros de 1 até {numero} é: {resultado}");




        }
    }
        
}
