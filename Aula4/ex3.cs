using System;

namespace Aula4_
{
    class Exercicio3__
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Bem-vindo à calculadora financeira!");

        
        Console.WriteLine("Digite o valor inicial (em R$): ");
        double valorInicial = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escolha o tipo de investimento:");
        Console.WriteLine("1. Poupança (rendimento de 3% ao ano)");
        Console.WriteLine("2. Renda Fixa (rendimento de 5% ao ano)");
        Console.WriteLine("3. Ações (rendimento de 10% ao ano, com chance de perda de 5%)");

        int tipoInvestimento = Convert.ToInt32(Console.ReadLine());

        Console.Write("Quantos anos você deseja investir? ");
        int ano = Convert.ToInt32(Console.ReadLine());

        double saldoFinal = valorInicial;

        for (int anos = 1; anos <= ano; anos++)
        {
            double taxa = 0;
            if(tipoInvestimento == 1)
            {
                taxa = 1.03;
            } else if (tipoInvestimento == 2){
                taxa = 1.05;
            
            } else if (tipoInvestimento == 3){
                taxa = (ano % 4 == 0)? 1.10 : 1.05;
            }
            saldoFinal *= taxa;

            Console.Write($"\n{anos}: {saldoFinal}");


    

        }

        }
        }   
}