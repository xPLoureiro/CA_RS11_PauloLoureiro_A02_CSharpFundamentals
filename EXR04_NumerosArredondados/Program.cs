using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXR04_NumerosArredondados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 4. Escreva um programa que apresente os números (8.456796, 9.8, 3.12345, 6) arredondados em três linhas diferentes. sendo que na primeira linha aparecem todos arredondados a três casas decimais, na segunda a umae na terceira a sem casa decimal.
             */
            Console.WriteLine("{0:F3} \t {1:F3} \t {2:F3} \t {3:F3}", 8.456796, 9.8, 3.12345, 6);//Três casas decimais
            Console.WriteLine("{0:F1} \t {1:F1} \t {2:F1} \t {3:F1}", 8.456796, 9.8, 3.12345,
            6);// Uma casa decimal
            Console.WriteLine("{0} \t {1} \t {2} \t {3}", (int)8.456796, (int)9.8, (int)3.12345, 6); // sem casas decimais… utilizou-se uma conversão de tipo (typ


        }
    }
}
