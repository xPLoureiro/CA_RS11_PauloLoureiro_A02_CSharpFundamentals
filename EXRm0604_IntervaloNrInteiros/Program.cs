using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0604_IntervaloNrInteiros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 4. Escreva um programa que receba dois números inteiros e gere os números inteiros que estão no intervalo compreendido por eles.
             */
            int inf, sup, i;
            Console.Write("Introduza o limite inferior do intervalo: ");
            inf = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o limite superior do intervalo: ");
            sup = Convert.ToInt32(Console.ReadLine());
            for (i = inf; i <= sup; i++) // ciclo com i a variar entre inf e sup
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
