namespace Aula9
{

    public class VariaveisImplicitas
    {

        static void Teste()
        {
           var nome = "C#";
           System.Console.WriteLine(nome);
           System.Console.WriteLine(nome.GetType());

           var idade = 20;
           System.Console.WriteLine(idade);
           System.Console.WriteLine(idade.GetType());

           var altura = 1.75;
           System.Console.WriteLine(altura);
           System.Console.WriteLine(altura.GetType());

           const double pi = 3.1415;
           System.Console.WriteLine(pi);
           System.Console.WriteLine(pi.GetType());

           var lista = new List<int> {1, 2, 3, 4, 5};
           System.Console.WriteLine(lista.GetType());
           System.Console.WriteLine(lista);

           foreach (var item in lista)
           {
            System.Console.WriteLine(item);
           }

           var dicionario = new Dictionary<string, int>
           {
            {"C#", 1},
            {"Java", 2},
            {"Python", 3}
           };
           System.Console.WriteLine(dicionario.GetType());

           foreach (var item in dicionario)
           {
            System.Console.WriteLine(item);
           }
        }

    }
}