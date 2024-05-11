using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXR14_PrecoComIva
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            14. Escrever um programa leia o valor base e o iva de um produto e que calcule o valor final do produto.
             */
            float b, iva;
            Console.Write("Introduza o preço base: ");
            b = Convert.ToSingle(Console.ReadLine());// Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            Console.Write("Introduza a taxa de IVA 0,6 ou 0,13 ou 0,23: "); // Deve ser introduzido como um nº real e não em percentagem
            iva = Convert.ToSingle(Console.ReadLine());// Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            Console.WriteLine("PVP={0:F2}EUR", b * (1 + iva));
            Console.ReadLine();
        }
    }
}
