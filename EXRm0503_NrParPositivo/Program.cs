using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0503_NrParPositivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 3. Escrever um programa para determinar se um número é par e positivo.
             */
            int numero;
            Console.WriteLine("Introduza um número inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero >= 0)
            {
                Console.WriteLine("O número {0} é positivo.", numero);
            }
            else
            {
                Console.WriteLine("O número {0} é negativo.", numero);
            }
            if (numero % 2 == 0)
            {
                Console.WriteLine("O número {0} é par.", numero);
            }
            else
            {
                Console.WriteLine("O número {0} é ímpar.", numero);
            }
            Console.ReadLine();

            /* v2 com op ternário
            int numero;
            Console.WriteLine("Introduza um número inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", numero >= 0 ? "é positivo" : "é negativo");
            Console.WriteLine("{0}", numero % 2 == 0 ? "é par" : "é ímpar");
            Console.ReadLine();
            */

            /* v3
            int i;
            Console.Write("Introduza um número inteiro: ");
            i = Convert.ToInt32(Console.ReadLine());
            if (i > 0) // Esta solução, após determinar se é positivo, distingue se é ou não par
                if (i % 2 == 0) // Poderiam ter-se utilizado apenas dois if mas o Português não seria tão correto
                Console.WriteLine("O número inteiro {0} é positivo e par", i);
                else
                Console.WriteLine("O número inteiro {0} é positivo mas não é par", i);
            else
                if (i % 2 == 0)
                Console.WriteLine("O número inteiro {0} não é positivo mas é par", i);
                else
                Console.WriteLine("O número inteiro {0} não é positivo nem par", i);
            Console.ReadLine();
            */
        }
    }
}
