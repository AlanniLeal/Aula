using System;

namespace Aula3
{
    class Exercicio
    {
        static void teste(string[] args)
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
        int anos = Convert.ToInt32(Console.ReadLine());

        double saldoFinal = valorInicial;

        
        switch (tipoInvestimento)
        {
            case 1: // Poupança
                saldoFinal = (valorInicial * 0.03) + valorInicial;
                break;

            case 2: // Renda Fixa
                saldoFinal = (valorInicial * 0.05 + valorInicial);
                break;

            case 3: // Ações
                saldoFinal = (valorInicial * 0.1) + valorInicial;
                Console.WriteLine($"Você pode ganhar {saldoFinal}");
                saldoFinal = valorInicial * 0.05;
                Console.WriteLine($"Você pode perder {saldoFinal}");
                break;




            default:
                Console.WriteLine("Opção inválida.");
                break; 
        }

        
        Console.WriteLine($"Saldo final estimado após {anos} ano(s): R$ {saldoFinal:F2}");

        // Console.WriteLine("Pressione qualquer tecla para sair.");
        // Console.ReadKey();
        }   
    }
}





































































