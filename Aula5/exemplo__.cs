namespace Aula5;

public class Exemplo__
{
    static void Teste()
    {
        int[] vetor = new int[10];
        for (int i = 0; i < 10; i++)
        {
            System.Console.Write("Digite um número:");
            vetor[i] = int.Parse(Console.ReadLine());

            // vetor[i] = Random.Next(1, 100);
        }
        //ordem direta
        System.Console.WriteLine("Ordem direta:");
        for (int i = 0; i < 10; i++)
        {
            System.Console.Write($"{vetor[i]}");
        }
        //ordem inversa
        System.Console.WriteLine("Ordem inversa:");
        for (int i = 0; i >= 0; i--)
        {
            System.Console.Write($"{vetor[i]}");
        }



        int[] vetor = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digite um número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        int menor = vetor[0];
        int maior = vetor[0];

        for (int i = 0; i < 10; i++)
        {

            if (vetor[i] < maior)
                maior = vetor[i];
            if (vetor[i] > menor)
                menor = vetor[i];
        }
    


            Console.WriteLine($"O menor número é: {menor}");
            Console.WriteLine($"O maior número é: {maior}");
        
    }
}








