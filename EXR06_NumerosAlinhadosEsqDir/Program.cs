using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXR06_NumerosAlinhadosEsqDir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             6. Escrever um programa que leia do utilizador 3 números e os apresente dois resultados diferentes:
                › Na 1ª linha, os números estão alinhados à esquerda, com duas casas decimais e cada um com 20casas.
                › Na 2ª linha, os números estão alinhados à direita, com uma casa decimal e cada um com 20 casas.
             */

            float a, b, c;

            Console.Write("Introduza um número: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Introduza um número: ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Introduza um número: ");
            c = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("{0,-20:F1}{1,-20:F1}{2,-20:F1}", a, b, c);
            // São reservados 20 caracteres para escrever cada número.
            // O alinhamento é à esquerda faz-se com o sinal - (menos).
            Console.WriteLine("{0,20:F1}{1,20:F1}{2,20:F1}", a, b, c);
            // São reservados 20 caracteres para escrever cada número.
            // O alinhamento é à direita faz-se por omissão.
        }
    }
}
