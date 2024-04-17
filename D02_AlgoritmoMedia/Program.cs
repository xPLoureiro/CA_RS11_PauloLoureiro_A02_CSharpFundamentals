using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_AlgoritmoMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
   
                Declarar variáveis


            Camel Case  --> camelCase
            
            // em T-SQL seria:
            // DECLARE @numero1 AS int = 10; 
            // DECLARE @numero1 AS int;
            // SET @numero1 = 10
            // SELECT @numero1 * 10000
            
            
            // tipo_de_dados nome_da_variável
            */


            // 1. Declarar as variáveis, podia ser assim: int valor01, valor02;
            string valor01;
            int valor02;
            double resultado;


            // 2. Pedir o 1º valor
            Console.Write("Número 1: ");
            valor01 = Console.ReadLine();         // quando for fazer o cálculo, vou ter de converter

            // 3. Pedir o 2º valor
            Console.Write("Número 2: ");
            valor02 = Convert.ToInt16(Console.ReadLine());          // vou ter de converter ao ler o valor

            // 4. Calcular a média
            resultado = (Convert.ToDouble(valor01) + Convert.ToDouble(valor02)) / 2;

            // 5. Mostrar o resultado
            Console.WriteLine("Média: " + resultado.ToString());       // melhorar a concatenação!!

            // 6. Pausar a consola
            Console.ReadKey();

        }
    }
}
