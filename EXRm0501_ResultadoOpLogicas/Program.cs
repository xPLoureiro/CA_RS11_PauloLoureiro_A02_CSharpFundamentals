using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0501_ResultadoOpLogicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * MÓDULO 5 – Instruções de decisão
             * 1. Escrever um programa que apresente o resultado das seguintes operações lógicas:
             */
            Console.WriteLine("2 == 3? resultado: {0}", 2 == 3);
            Console.WriteLine("8 != 12? resultado: {0}", 8 != 12);
            Console.WriteLine("14 > 15? resultado: {0}", 14 > 15);
            Console.WriteLine("true == false? resultado: {0}", true == false);
            Console.WriteLine("'a' == 'a'? resultado: {0}", 'a' == 'a');
            Console.WriteLine("'a' == 'b'? resultado: {0}", 'a' == 'b');
            Console.WriteLine("2 < 3 E 3 > 4? resultado: {0}", 2 < 3 && 3 > 4);
            Console.WriteLine("2 < 3 OU 3 > 4? resultado: {0}", 2 < 3 || 3 > 4);
            Console.WriteLine("NAO(2 < 3 || 3 > 4)? resultado: {0}", !(2 < 3 || 3 > 4));
            Console.ReadLine();
        }
    }
}
