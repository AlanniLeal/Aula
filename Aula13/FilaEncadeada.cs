using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula13
{
    public class FilaEncadeada
    {
        class Node
        {
            public int valor;
            public Node? proximo;
        }

        static Node? inicio = null;
        static Node? fim = null;

        static int contador = 0;

        
        static void Enfileirar(int valor)
        {
            
            Node novoNode = new Node { valor = valor, proximo = null };

           
            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                
                fim!.proximo = novoNode; 
            }

            // Atualiza o fim da fila
            fim = novoNode;

            // Incrementa o contador
            contador++;
        }

        // Desenfileirar é remover o elemento do início da fila
        static void Desenfileirar()
        {
            if (inicio == null)
            {
                Console.WriteLine("Fila vazia!");
                return;
            }

            Console.WriteLine($"Desenfileirando {inicio.valor}");

            // Atualiza o início da fila
            inicio = inicio.proximo;

            // Se a fila ficou vazia, atualiza o fim da fila
            if (inicio == null)
            {
                fim = null;
            }

            // Decrementa o contador
            contador--;
        }

        // Listar a Fila
        static void Listar()
        {
            if (inicio == null)
            {
                Console.WriteLine("Fila vazia!");
                return;
            }
            System.Console.WriteLine("Listando a Fila");
            Node? atual = inicio;
            while (atual != null)
            {
                Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }

        static void Main()
        {
            Enfileirar(10);
            Enfileirar(20);
            Enfileirar(30);
            Listar();
            Desenfileirar();
            Listar();
            Desenfileirar();
            Listar();
            Desenfileirar();
            Listar();
            Desenfileirar();
        }
    }
}