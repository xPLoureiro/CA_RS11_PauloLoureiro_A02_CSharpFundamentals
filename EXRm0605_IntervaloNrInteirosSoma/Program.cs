using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0605_IntervaloNrInteirosSoma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 5. Altere o programa anterior para mostrar no final a soma dos números.
             (4. Escreva um programa que receba dois números inteiros e gere os números inteiros que estão no intervalo compreendido por eles.)
             */
            int inf, sup, i, soma = 0;
            Console.Write("Introduza o limite inferior do intervalo: ");
            inf = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o limite superior do intervalo: ");
            sup = Convert.ToInt32(Console.ReadLine());
            for (i = inf; i <= sup; i++) // Ciclo com i a variar entre inf e sup
            {
                Console.Write("{0}", i);
                if (i != sup) // Se não for o último número acrescenta o operador +
                    Console.Write("+");
                soma += i; //Vai adicionando cada um dos números à variável soma
            }
            Console.Write("={0}\n", soma);
            Console.ReadLine();
        }
    }
}
