using System;

namespace Ativ_
{
    class Atv5
    {
    static int  SomaElementos (int [] vetor, int indice)
    {
        if (indice == vetor.Length)
            return 0;
        return vetor[indice] + SomaElementos(vetor, indice + 1);

    }
    static double MediaElementos(int[] vetor)
        {
            
            int soma = SomaElementos(vetor, 0);
            return (double)soma / vetor.Length;
        }
      static void Teste()
        {
            int[] vetor = {1, 2, 3, 4, 5, 6, 7, 8};

            double media = MediaElementos(vetor);

            System.Console.WriteLine($"A média dos elementos do vetor é: {media}");
       }
   }
}




//versao professor

// using system;

// name space Ativ_
// {
//     class Atv5
//     {
//         static (int, double) SomaMedVetor(int [] vetor, int index, int tamanho)
//         {
//         if (index < 0)
//             return (0, 0.0)

//         //chamada recursiva
//         (int somaParcial, double _) = SomaMedVetor(vetor, index - 1, tamanho)
//         int somaTotal = somaParcial + vetor[index];

//         double media = (double)somaTotal / tamanho;

//         return (somaTotal, media);
//         }

//         static void Main(string[] args)
//         {
//             Console.Write("Digite o tamanho do vetor: ");
//             int tamanho = int.Parse(Console.ReadLine());
//             int[] vetor = new int[tamanho];

//             for (int i = 0; i < tamanho; i++)
//             {
//                 Console.Write($"Digite o elemento {i + 1}: ");
//                 vetor[i] = int.Parse(Console.ReadLine());
//             }

//             (int soma, double media) = SomaMediaVetor(vetor, tamanho - 1, tamanho);
//             Console.WriteLine($"A soma dos elementos do vetor é: {soma}");
//             Console.WriteLine($"A média dos elementos do vetor é: {media}");
//         }
//     }
// }