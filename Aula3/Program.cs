using System;

namespace Aula3
{
    internal class Program
    {
        public static void Teste()
        {
            int idade = 15;
            if ( idade >= 19 && idade <=50 ){
                System.Console.WriteLine("Adulto");
            }    
            else if (idade > 50 && idade <= 100){
                System.Console.WriteLine("Idoso");
            }
            else if (idade > 100){
                System.Console.WriteLine("Já morreu");
            }
             else{
                System.Console.WriteLine("Criança");
            }    
        }
    }
}            
                    
