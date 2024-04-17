/*
    Decidir qual de dois números é o maior, ou se são iguais.

*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_AlgoritmoMaiorDeDoisNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Declarar as variáveis
            double numero1, numero2;
            //string menor, igual, maior;

            // 2. Pedir o 1º valor
            Console.Write("Qual é o número 1? ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            // 3. Pedir o 2º valor
            Console.Write("Qual é o número 2? ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            if (numero1 < numero2)
                {
                Console.WriteLine("O número 1 é menor do que o número 2");
                }
            else if (numero1 > numero2)
                {
                Console.WriteLine("O número 1 é maior do que o número 2");
                }             
            else
                {
                Console.WriteLine("O número 1 é igual ao número 2");
                }
                   
            Console.ReadKey();

        }
    }
}
