using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXR17_DespesaMediaDiariaTurista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            17. Escrever um programa que calcule a despesa média diária que um turista despendeu numa viagem de quatro dias ao Porto, sabendo que cada dia gastou mais 20% do que no dia anterior. O valor da despesa deverá ser apresentado sem casas decimais. 
             */
            double p, t;
            Console.Write("Qual foi a despesa do 1º dia: "); // Não é feita validação, ou seja o utilizador pode introduzir caracteres inválidos 
            p = Convert.ToSingle(Console.ReadLine());
            t = p * (1 + 1.2 + 1.2 * 1.2 + 1.2 * 1.2 * 1.2) / 4;
            Console.WriteLine("1º dia: {0}", p);
            Console.WriteLine("2º dia: {0}", p * 1.2);
            Console.WriteLine("3º dia: {0}", p * 1.2 * 1.2);
            Console.WriteLine("4º dia: {0}", p * 1.2 * 1.2 * 1.2);
            Console.WriteLine("Média diária dos 4 dias: {0:F0} ", t);
            Console.ReadLine();
        }
    }
}
