using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0506_AprovacaoFormando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             */
            float teste1, teste2;
            Console.Write("Introduza a nota do 1ºteste: ");
            teste1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Introduza a nota do 2º teste: ");
            teste2 = Convert.ToSingle(Console.ReadLine());
            if (teste1 >= 8 && teste2 >= 8 && (teste1 + teste2) / 2 >= 9.5)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
            Console.ReadLine();
        }
    }
}
