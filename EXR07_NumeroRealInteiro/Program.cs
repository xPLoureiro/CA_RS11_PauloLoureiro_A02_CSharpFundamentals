using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXR07_NumeroRealInteiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             7. Escrever um programa que apresente no ecrã a parte inteira de um número introduzido pelo utilizador.
             */

            float n;

            Console.Write("Introduza um número real: "); // Não há validação! Só orientação para o utilizador escrever um número real
            n = Convert.ToSingle(Console.ReadLine()); // Atenção que se a consola for em PT, o separador decimal é a vírgula
        }
    }
}
