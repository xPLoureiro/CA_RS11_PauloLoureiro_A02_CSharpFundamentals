using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E06_Calculadora_v02_ComClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora minhaCalculadora = new Calculadora();

            Utility.WriteTitle("Calculadora Simples com classes");

            Utility.WriteMessage("Digite o primeiro valor: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("Digite o segundo valor: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("Escolha a operação:");
            Utility.WriteMessage("(+) Soma");
            Utility.WriteMessage("(-) Subtração");
            Utility.WriteMessage("(*) Multiplicação");
            Utility.WriteMessage("(/) Divisão");
            Utility.WriteMessage("Opção: +, -, * ou /");
            string opcao = Console.ReadLine();

            double resultado = 0;

            switch (opcao)
            {
                case "+":
                    resultado = minhaCalculadora.Somar(num1, num2);
                    break;
                case "-":
                    resultado = minhaCalculadora.Subtrair(num1, num2);
                    break;
                case "*":
                    resultado = minhaCalculadora.Multiplicar(num1, num2);
                    break;
                case "/":
                    resultado = minhaCalculadora.Dividir(num1, num2);
                    break;

                /*try
                {
                    resultado = minhaCalculadora.Dividir(num1, num2);
                }
                catch (DivideByZeroException ex)
                {
                    Utility.WriteMessage(ex.Message);
                    return;
                }
                */

                default:
                    Utility.WriteMessage("Opção inválida.");
                    return;
            }

            Utility.WriteMessage($"Resultado: {resultado}");

            Utility.TerminateConsole();
        }
    }
}
