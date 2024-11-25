// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula13
// {
//     public class ListaEncadeada
//     {
//         static delegate void FuncaoDelegate(int valor);

//         static FuncaoDelegate? inicio = null;

//         static FuncaoDelegate CriarNo(int valor, FuncaoDelegate? proximo)
//         {
//             return v =>
//             {
//                 Console.WriteLine(valor);
//                 proximo?.Invoke(v);
//             };
//         }
//     }
// }