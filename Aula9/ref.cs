using System;

namespace Aula9
{
    class Ref
    {
        static int Quadradado(int x){
            return x *x;
        }
        static void QuadradadoRef(ref int x){
            x = x * x;
        }
        static int QuadradadoOut(out int x)
        {
            x = 6;
            return x * x;
        }

        static void Teste()
        {
            int a = 10;
            System.Console.WriteLine(Quadradado(a));
            System.Console.WriteLine(a);
            QuadradadoRef(ref a);
            System.Console.WriteLine(a);

            int b;
            System.Console.WriteLine(QuadradadoOut(out b));
        }
    }
}