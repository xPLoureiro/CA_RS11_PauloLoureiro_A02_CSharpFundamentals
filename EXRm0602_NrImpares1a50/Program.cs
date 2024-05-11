using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0602_NrImpares1a50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             2. Escreva um programa que imprima no ecrã os números ímpares entre 1 e 50.
             */
            // v1
            /*
            int i;
            for (i = 1; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
            Console.ReadLine();
            */
            int i;
            for (i = 1; i <= 50; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
