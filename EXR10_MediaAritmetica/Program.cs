using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXR10_MediaAritmetica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 10. Criar uma apliação do tipo consola para receber do utilizador dois valores inteiros e devolver a média aritmética.
             */
            int a, b;
            double media;

            Console.Write("Introduza um número inteiro: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza outro número inteiro: ");
            b = Convert.ToInt32(Console.ReadLine());
            media = (a + b) / 2;
            Console.WriteLine("A média entre o nº {0} e {1} é de {2}.", a, b, media);
            Console.ReadLine();
            /* A última instrução foi acrecentada para o utilizador conseguir visualizar o resultado antes da consola fechar.*/

        }
    }
}
