using System;

namespace Aula2
{
    internal class Triangulo
    {
        static void Teste()
        {
            
            int h = 10;
            int b = 20;
            int A = b*h/2;
            System.Console.WriteLine(A);

            //System.Console.WriteLine("Digite um texto:");
            //string texto = System.Console.ReadLine();
            //System.Console.WriteLine("O texto digitadofoi" + texto);

            //System.Console.WriteLine("Digite um numero");
            //int numero = int.Parse(Console.ReadLine());
           //System.Console.WriteLine("O numero digitado foi " + numero);

            System.Console.WriteLine("Digite se é verdadeiro ou falso");
            bool verdadeiroOuFalso = bool.Parse(System.Console.ReadLine());
            System.Console.WriteLine("O valor digitado foi " + verdadeiroOuFalso);

            System.Console.WriteLine("Entre com seu nome completo:");
            string texto = System.Console.ReadLine();
            System.Console.WriteLine("O nome é" + texto);

            System.Console.WriteLine("Quantos quartos tem na sua casa");
            int numero = int.Parse(Console.ReadLine());
            System.Console.WriteLine("O numero de quartos é " + numero);





            





        }

    }
}