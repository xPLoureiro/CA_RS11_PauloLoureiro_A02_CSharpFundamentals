using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXR11_Cambio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             11. Escreva um programa que converta dólares americanos para euros (a taxa de câmbio é de 1,1579 USD para 1€).
             */

            float d, t = 1.1579F;
            // Taxa de câmbio: 1,1579 - a letra F no fim do número significa que é do tipo float
            //sem o F seria considerado do tipo double e originaria um erro na atribuição
            Console.Write("Quantos dólares pretende converter: ");
            // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            d = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("${0}={1}EUR", d, d * t);
            Console.ReadLine();

            // corrigir 
        }
    }
}
