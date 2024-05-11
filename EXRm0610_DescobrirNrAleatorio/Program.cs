using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0610_DescobrirNrAleatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 10. Escrever um programa que permita descobrir aleatoriamente um número gerado pelo computador.
                Dica: Utilizar a classe Random
                Randon rnd = new Random();
                int numeroSecreto = rnd.Next(<valorInicial>, <valorFinal>);
             */
            int n;
            Random rnd = new Random();
            int numeroSecreto = rnd.Next(1, 6);
            do
            {
                Console.WriteLine("Introduza um nº: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (numeroSecreto != n);
            Console.WriteLine("Acertou!");
            Console.ReadLine();
        }
    }
}
