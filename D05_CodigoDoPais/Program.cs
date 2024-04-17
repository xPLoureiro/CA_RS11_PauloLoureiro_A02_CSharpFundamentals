using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_CodigoDoPais
{
    internal class Program
    {
        static void Main(string[] args)
        {




            #region v1: IFs

            string nome, codigoPais;
                        
            Console.Write("Qual é o teu nome? ");
            nome = Console.ReadLine();
                       
            Console.Write("Qual é o código do teu país? ");
            codigoPais = Console.ReadLine().ToUpper();

            if (codigoPais == "PT")
            {
                Console.WriteLine("Olá " + nome + " tu és de Portugal");
            }
            else if (codigoPais == "BR")
            {
                Console.WriteLine("Olá " + nome + " tu és de Brasil");
            }
            else if (codigoPais == "FR")
            {
                Console.WriteLine("Olá " + nome + " tu és de França");
            }
            else if (codigoPais == "ES")
            {
                Console.WriteLine("Olá " + nome + " tu és de Espanha");
            }
            else if (codigoPais == "MZ")
            {
                Console.WriteLine("Olá " + nome + " tu és de Moçambique");
            }
            else
            {
                Console.WriteLine("Olá " + nome + " tu és de outro país");
            }

            Console.ReadKey();

        }

        #endregion


        #region v2: Switch

        #endregion















    }
}
