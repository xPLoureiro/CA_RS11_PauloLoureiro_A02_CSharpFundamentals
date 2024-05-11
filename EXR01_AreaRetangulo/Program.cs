using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXR01_AreaRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                1. Apresentar a área de um retângulo a partir de dois valores (altura e largura) introduzidos pelo utilizador.
                Nota: area = altura * largura
            */

            int a, l;
            Console.WriteLine("Introduzir a altura:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzir a largura:");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A area do retângulo é de {0}.", a * l);
        }
    }
}