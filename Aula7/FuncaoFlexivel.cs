namespace Aula7
{
    public class FuncaoFlexivel
    {

        public delegate int Operacao(int a, int b);

        //expressao lambda
        static int Soma(int a, int b) => a + b;

        //juntar duas funções delegate
        public delegate void Notificar();
        public static void EnvioEmail() => System.Console.WriteLine("Email enviado");
        public static void EnviarSMS() => System.Console.WriteLine("SMS enviado");
        static void Main(string[] args)
        {
            Operacao op = Soma;
            System.Console.WriteLine(op(3, 2));

            Operacao op2 = (int a, int b) => a * b;
            System.Console.WriteLine(op2(3, 2));

            Func<int, int, int> op3 = delegate(int a, int b) {return a - b; };
            System.Console.WriteLine(op3(3, 2));

            Notificar notificar = EnvioEmail;
            notificar += EnviarSMS;
            notificar();




        }





    }


}