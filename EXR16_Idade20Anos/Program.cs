using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXR16_Idade20Anos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             16. Escrever um programa que apresente ao utilizador a sua idade daqui a vinte anos.
             */
            int idade;
            Console.WriteLine("Introduza a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Daqui a 20 anos terá {0}.", idade + 20);
            Console.ReadLine();
        }
    }
}
