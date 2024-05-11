using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0606_MaxMinSequencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 6. Escreva um programa que leia uma sequência de números inteiros a partir do teclado e apresente o máximo e o mínimo. O programa termina quando o número lido for zero.
             */
            int num, min, max;
            Console.WriteLine("Inserir nº inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());
            min = num;
            max = num;
            while (num != 0)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
                Console.WriteLine("Inserir nº inteiro (para parar inserir 0): ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            if (max == 0 && min == 0) // Se max e min têm o valor zero quer dizer que o primeiro nº digitado foi zero, ou seja, a condição de saída
            Console.WriteLine("Não foi introduzido nenhum número");
            else
                Console.WriteLine("O valor máximo é {0} e o mínimo é {1}", max, min);
            Console.ReadLine();
        }
    }
}
