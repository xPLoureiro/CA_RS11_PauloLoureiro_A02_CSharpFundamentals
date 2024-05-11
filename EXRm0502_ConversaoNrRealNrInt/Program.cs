using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0502_ConversaoNrRealNrInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 2. Escrever um programa para converter um número real positivo para um número inteiro. Deve ainda de
arredondar o número.
             */
            float numero;
            int numArredondado;
            Console.Write("Introduza um valor real positivo: "); // Não é feita validação.
            numero = Convert.ToSingle(Console.ReadLine());
            if (numero - (int)numero < 0.5) // (int)numero representa a parte inteira
            {
                numArredondado = (int)numero; // arredonda por defeito
            }
            else
            {
                numArredondado = (int)numero + 1; // // ELSE arredonda por excesso
            }
            Console.WriteLine("Valor inteiro arredondado: {0}", numArredondado);
            Console.ReadLine();
        }
    }
}
