using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0505_NrMaior3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 5. Escrever um programa que permita identificar o número maior entre três números introduzidos pelo utilizador.
             */
            int a, b, c;
            Console.Write("Introduza o primeiro valor: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o terceiro valor: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("Maior valor: {0}", a);
                }
                else
                {
                    if (b > c)
                    {
                        Console.WriteLine("Maior valor: {0}", b);
                    }
                    else
                    {
                        Console.WriteLine("Maior valor: {0}", c);
                    }
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("Maior valor: {0}", b);
                }
                else
                {
                    if (a > c)
                    {
                        Console.WriteLine("Maior valor: {0}", a);
                    }
                    else
                    {
                        Console.WriteLine("Maior valor: {0}", c);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
