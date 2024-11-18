using System;
using System.Collections.Generic;

namespace Exerc1811
{
    class Eexer3
    {
        //função de ordenação usando Select Sort
        static void Ordernar(string[] vetor )
        {
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                int nomeMenor = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (string.Compare(vetor[j], vetor[nomeMenor]) < 0)
                    {
                        nomeMenor = j;
                    }
                }
                string p = vetor[i];
                vetor[i] = vetor[nomeMenor];
                vetor[nomeMenor] = p;
            }
        }
        static void Imprimir(string[] vetor)
        {
            foreach (string nome in vetor)
            {
                System.Console.WriteLine();
            }
           
        }
        static void Teste()
        {
              List<string> nomes = new List<string>();

            Console.WriteLine();

              while (true)
            {
                Console.Write("Digite um nome: ");
                string nome = Console.ReadLine();

                if (string.IsNullOrEmpty(nome)) 
                    break;

                nomes.Add(nome); 
            }

            string[] vetor = nomes.ToArray();


            System.Console.WriteLine("Nomes desordenados");
            Imprimir(vetor);
            Ordernar(vetor);
            System.Console.WriteLine("Nomes ordenados ");
            Imprimir(vetor);
        }
    }
}