using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0513_VogalConsoante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 13. Escrever um programa para identificar se o carácter introduzido pelo utilizador é uma vogal ou uma consoante.
             */
            char c;
            Console.Write("Introduza uma carácter: ");
            c = Convert.ToChar(Console.ReadLine());
            if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
                if (c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' || c == 'I' || c == 'o' || c == 'O' || c == 'u' || c == 'U')
                    Console.WriteLine("Vogal");
                else
                    Console.WriteLine("Consoante");
            else
                Console.WriteLine("Outro carácter!");
            Console.ReadLine();
        }
    }
}
