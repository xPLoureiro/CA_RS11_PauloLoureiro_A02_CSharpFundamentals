using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0611_DescobrirNrAleatorioTentativas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * 11. Alterar o exercício anterior para contabilizar o nº de tentativas falhadas.
             (10.Escrever um programa que permita descobrir aleatoriamente um número gerado pelo computador.
                Dica: Utilizar a classe Random
                Randon rnd = new Random();
            int numeroSecreto = rnd.Next(< valorInicial >, < valorFinal >);)
            */
            int n, numeroTentativas = 0;
            Random rnd = new Random();
            int numeroSecreto = rnd.Next(1, 3);
            do
            {
                Console.WriteLine("Introduza um nº: ");
                n = Convert.ToInt32(Console.ReadLine());
                numeroTentativas++;
            }
            while (numeroSecreto != n);
            Console.WriteLine("Acertou após {0} tentativas.", numeroTentativas);
            Console.ReadLine();
        }
    }
}
