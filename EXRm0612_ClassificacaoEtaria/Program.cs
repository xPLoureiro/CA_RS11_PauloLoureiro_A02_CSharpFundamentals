using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0612_ClassificacaoEtaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 12. Escrever um programa que peça a n pessoas de uma empresa a sua idade. No final o programa deverá verificar se a média de idades varia entre 0 e 25, 26 e 60 e maior que 60; e dizer se os funcionários são jovens, adultos ou idosos, conforme a média calculada.
             */
            int totalFuncionarios, idade, somaIdades = 0;
            float media;
            Console.WriteLine("Quantas pessoas tem a empresa?");
            totalFuncionarios = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= totalFuncionarios; i++)
            {
                Console.WriteLine("Qual é a idade do {0} funcionário?", i);
                idade = Convert.ToInt32(Console.ReadLine());
                somaIdades += idade;
            }
            media = somaIdades / totalFuncionarios;
            if (media > 60)
            {
                Console.WriteLine("Funcionários idosos.");
            }
            else
            {
                if (media > 25)
                {
                    Console.WriteLine("Funcionários adultos.");
                }
                else
                {
                    Console.WriteLine("Funcionários jovens.");
                }
                Console.ReadLine();
            }
        }
    }
}
