using System;
using System.Globalization;
namespace Exemplo
{
    internal class Exemplo_3
    {
        static void Main(String[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("O " + produto1 + ", cujo preço é $"  + preco1);
            Console.WriteLine("A " + produto2 + ", cujo preço é $" + preco2);
            Console.WriteLine($"Registro {idade} anos de idade , codigo  {codigo}  e genero:  {genero}");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arrendondado {medida:F3}");
            Console.WriteLine($"Separador decimal {medida.ToString("N3", CultureInfo.InvariantCulture)}");


            
                
            

        
        }
    }
}