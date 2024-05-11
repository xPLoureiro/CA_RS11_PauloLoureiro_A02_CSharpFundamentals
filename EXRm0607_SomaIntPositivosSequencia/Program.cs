using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0607_SomaIntPositivosSequencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 7. Escreva um programa que leia uma sequência de números inteiros a partir do teclado e acumule unicamente a soma dos inteiros positivos. O programa termina quando o número lido for zero.
               CICLO DO..WHILE
             */
            //OPÇÃO MAIS ADEQUADA!
            int n, soma = 0;
            do
            {
                Console.Write("Introduza um nº inteiro (zero para sair): ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                    soma += n;
            } while (n != 0);
            Console.WriteLine("Soma dos inteiros positivos: {0}", soma);
            Console.ReadLine();

            //OPÇÃO possível!
            /*
            int num = -1, soma = 0;
            while (num != 0)
            {
                Console.WriteLine("Inserir nº: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    soma = soma + num;
                    num++;
                }
            }
            Console.WriteLine("Soma dos inteiros positivos: {0}", soma);
            Console.ReadLine();
            */
        }
    }
}
