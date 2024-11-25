
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula12
{
    public class lista
    {
        static int[] vetor = new int[10];

        static void Inserir(int valor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == 0)
                {
                    vetor[i] = valor;
                    break;
                }
            }
        }
        static void Remover(int valor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == valor)
                {
                    vetor[i] = 0;
                    break;
                }
            }
        }
        static void Listar()
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] != 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }

       
        static void ListarInverso()
        {
            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                if (vetor[i] != 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }

        
        public static void Teste()
        {
            Inserir(10);
            Inserir(20);
            Inserir(30);
            Inserir(40);
            Inserir(50);
            Inserir(60);
            Inserir(70);
            Inserir(80);
            Inserir(90);
            Inserir(100);
            Listar();
            Console.WriteLine("Listar de forma inversa");
            ListarInverso();
            Remover(50);
            Console.WriteLine("Listar após remover o valor 50");
            Listar();
        }

    }
}