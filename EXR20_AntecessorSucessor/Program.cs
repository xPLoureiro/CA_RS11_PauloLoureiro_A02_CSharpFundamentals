using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXR20_AntecessorSucessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 20. Escreva um programa que apresente no ecrã antecessor e sucessor de um número introduzido pelo utilizador.
             */
            int n;
            Console.Write("Introduza um nº inteiro: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Antecessor: {0} \nSucessor: {1}", n - 1, n + 1);
            Console.ReadLine();
        }
    }
}
