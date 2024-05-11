using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0508_AnoBissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               8. Escrever um programa que determine se o ano introduzido é bissexto.
               NOTA:
               Anos divisíveis por 4 ou 400 são bissextos, LOGO: ano % 400 == 0 || ano % 4 == 0
               E ano não divisível por 100 são bissextos, LOGO: ano % 100 != 0
            */
            int ano;
            Console.Write("Introduza o ano: ");
            ano = Convert.ToInt32(Console.ReadLine());
            if ((ano % 400 == 0 || ano % 4 == 0) && ano % 100 != 0) // Note que os parênteses na conjunção(&&) são desnecessários já que este operador tem maior precedência que a disjunção(||)
            {
                Console.WriteLine("O ano {0} é bissexto", ano);
            }
            else
            {
                Console.WriteLine("O ano {0} não é bissexto", ano);
            }
            Console.ReadLine();
        }
    }
}
