using System;

namespace Exemplo12ListPilhFilaENCADEADA
{
    class Lista
    {
        
        class Node
        {
            public int Valor;      
            public Node? Proximo;  
        }

        private Node? inicio = null;

        
        public void Inserir(int valor)
        {
            Node novoNode = new Node { Valor = valor, Proximo = null };

            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                Node atual = inicio;
                while (atual.Proximo != null)
                {
                    atual = atual.Proximo;
                }
                atual.Proximo = novoNode;
            }
        }

        
        public void Excluir(int valor)
        {
            if (inicio == null) return;

            if (inicio.Valor == valor)
            {
                inicio = inicio.Proximo;
                return;
            }

            Node atual = inicio;
            while (atual.Proximo != null && atual.Proximo.Valor != valor)
            {
                atual = atual.Proximo;
            }

            if (atual.Proximo != null)
            {
                atual.Proximo = atual.Proximo.Proximo;
            }
        }

        
        public void Listar()
        {
            if (inicio == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }

            Node? atual = inicio;
            Console.WriteLine("Elementos na lista:");

            while (atual != null)
            {
                Console.WriteLine(atual.Valor);
                atual = atual.Proximo;
            }
        }

        
        static void Teste()
        {
            Lista lista = new Lista();

            // Insere valores na lista
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);

           
            lista.Listar();

            
            Console.WriteLine("Excluir 20");
            lista.Excluir(20);
            lista.Listar();
        }
    }
}