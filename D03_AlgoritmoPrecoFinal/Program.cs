using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_AlgoritmoPrecoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // 1. Declarar as variáveis
            string nomeProduto;
            double precoInicial, taxaDesconto, precoFinal;

            // 2. Pedir o 1º valor
            Console.Write("Qual o nome do produto? ");
            nomeProduto = Console.ReadLine();         

            // 3. Pedir o 2º valor
            Console.Write("Qual o preço inicial? ");
            precoInicial = Convert.ToDouble(Console.ReadLine());         

            // 4. Pedir o 3º valor
            Console.Write("Qual o desconto a aplicar sobre o preço inicial? ");
            taxaDesconto = Convert.ToDouble(Console.ReadLine());

            // 5. Calcular a preço final
            precoFinal = precoInicial * (1 - taxaDesconto/100);

            // 6. Mostrar o resultado
            Console.Write("O preço final do produto " + nomeProduto + "é: " + precoFinal.ToString());       

            // 7. Pausar a consola
            Console.ReadKey();



        }
    }
}
