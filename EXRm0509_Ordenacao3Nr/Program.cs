using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0509_Ordenacao3Nr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 9. Escrever um programa que devolva ao utilizador, por ordem crescente, os três números introduzidos inicialmente.
             */
            int p, s, t;
            Console.Write("Introduza o primeiro valor: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o segundo valor: ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o terceiro valor: ");
            t = Convert.ToInt32(Console.ReadLine());
            if (p < s)
            {
                if (p < t)
                {
                    if (s < t)
                    {
                        Console.WriteLine("{0} {1} {2}", p, s, t);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", p, t, s);
                    }
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", t, p, s);
                }
            }
            else
            {
                if (s < t)
                {
                    if (p < t)
                    {
                        Console.WriteLine("{0} {1} {2}", s, p, t);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", s, t, p);
                    }
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", t, s, p);
                }
            }
            Console.ReadLine();
        }
    }
}
