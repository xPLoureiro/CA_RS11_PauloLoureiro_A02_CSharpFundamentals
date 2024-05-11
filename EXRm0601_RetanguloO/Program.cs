using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0601_RetanguloO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * MÓDULO 6 – Instruções de repetição
             * 1. Escrever um programa que imprima no ecrã um retângulo com o símbolo “0” sabendo a sua largura e comprimento.
             */
            int i, j, largura, comprimento;
            Console.WriteLine("Indicar a largura:");
            largura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indicar o comprimento:");
            comprimento = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < largura; i++)
            {
                for (j = 0; j < comprimento; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
