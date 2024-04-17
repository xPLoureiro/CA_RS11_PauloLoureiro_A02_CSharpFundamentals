using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, codigoPais;

            Console.Write("Qual é o teu nome? ");
            nome = Console.ReadLine();

            Console.Write("Qual é o código do teu país? ");
            codigoPais = Console.ReadLine().ToUpper();

            switch (codigoPais)
            {
                case "PT":
                    Console.WriteLine("Olá " + nome + " tu és de Portugal");
                    break;
                case "BR":
                    Console.WriteLine("Olá " + nome + " tu és de Brasil");
                    break;
                case "FR":
                    Console.WriteLine("Olá " + nome + " tu és de França");
                    break;
                case "ES":
                    Console.WriteLine("Olá " + nome + " tu és de Espanha");
                    break;
                case "MZ":
                    Console.WriteLine("Olá " + nome + " tu és de Moçambique");
                    break;
                default:
                    Console.WriteLine("Olá " + nome + " tu és de outro país");
                    break;
            }
                    Console.ReadKey();

            }
    }
}
