using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0507_AprovacaoFormandoOpTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 7. Escrever um programa, utilizando o operador ternário, que apresente a mensagem de “Parabéns” se umformando obteve uma nota superior a 10. No caso contrário, apresente a mensagem “Ups, deve marcar novo exame.”
             */
            int nota;
            Console.WriteLine("Introduzir a nota final");
            nota = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nota >= 10 ? "Parabéns!" : "Ups, deve marcar novo exame.");
            //OU
            //Console.WriteLine("{0}", nota >= 10 ? "Parabéns!" : "Ups, deve marcar novo exame.");
            Console.ReadLine();
        }
    }
}
