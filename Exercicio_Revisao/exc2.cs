using System;

namespace Exercicio_Revisao
{
    class revisao
    {
        static void Teste()
        {
            string senhaCorreta = "Digix";
            System.Console.WriteLine("Digite a senha");
            string senhaInserida = System.Console.ReadLine();

            if (senhaInserida == senhaCorreta)
            {
                Console.WriteLine("Acesso autorizado");
            }
            else
            {
                Console.WriteLine("Acesso negado");

            }
        }
    }
}