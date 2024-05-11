using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0609_SomaDigitosNr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 9. Escreva um programa que leia um número inteiro e calcule a soma dos seus dígitos.
             */
            int n, soma = 0;
            Console.Write("Introduza um número inteiro: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0) // Sugestão: Faça execução passo a passo (F10) e observe os valores das variáveis na janela Locais
            {
                soma += n % 10; // O resto da divisão por 10 permite obter cada um dos dígitos do número
                n /= 10; // Depois da obtenção esse dígito é descartado
            }
            Console.WriteLine("Soma dos dígitos:{0}", soma);
            Console.ReadLine();
        }
    }
}
