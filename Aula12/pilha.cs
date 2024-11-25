using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula12
{
    public class Pilha
    {
        static int [] pilha = new int[10];
        
        static int topo = 0;

        public static void Adicionar(int valor)
        {
            if (topo < pilha.Length)
            {
                pilha[topo] = valor;
                topo++;
            }
            else
            {
                Console.WriteLine("Pilha cheia!");
            }
        }
        static void Remover()
        {
            if (topo > 0)
            {
                topo--;
                pilha[topo] = 0;
            }
            else
            {
                Console.WriteLine("Pilha vazia!");
            }
        }
        static void Listar()
        {
            for (int i = topo - 1; i >= 0; i--)
            {
                Console.WriteLine(pilha[i]);
            }
        }

        static void Main(string[] args)
        {
            Adicionar(10);
            Adicionar(20);
            Adicionar(30);
            Adicionar(40);

            Listar();

            Remover();

            Listar();
        }




    }
}