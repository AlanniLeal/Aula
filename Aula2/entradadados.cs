using System;

namespace Aula2
{
    class Entradadados
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Entre com seu nome completo");
            string nome = System.Console.ReadLine();

            System.Console.WriteLine("Quantos quartos tem na sua casa");
            int numero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com o preço de produtos");
            double preco = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com seus ultimo nome, idade e altura");
            string nda =  Console.ReadLine();
            string[] valores = nda.Split(" ");
            string ultimoNome = valores[0];
            int idade = int.Parse(valores[1]);
            double altura = double.Parse(valores[2]);

            System.Console.WriteLine($"{nome} \n{numero} \n{preco} \n{ultimoNome} \n{idade} \n {altura}");
            
        }

    }
}