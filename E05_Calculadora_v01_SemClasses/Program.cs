using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Calculadora_v01_SemClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int operacao;
            double valor01, valor02;
            double resultado = 0;

            Utility.WriteTitle("Calculadora Simples\r");

            Utility.WriteMessage("Escolha uma operação:", "\n", "\n");
            Utility.WriteMessage("\t1 - Adição");
            Utility.WriteMessage("\t2 - Subtração");
            Utility.WriteMessage("\t3 - Multiplicação");
            Utility.WriteMessage("\t4 - Divisão");
            Utility.WriteMessage("\nQual a operação pretendida? ");

            operacao = Convert.ToInt32(Console.ReadLine());

            Utility.WriteMessage("\nInsira o primeiro valor:");
            valor01 = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("\ninsira o segundo valor:");
            valor02 = Convert.ToDouble(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    resultado = valor01 + valor02;
                    break;
                case 2:
                    resultado = valor01 - valor02;
                    break;
                case 3:
                    resultado = valor01 * valor02;
                    break;
                case 4:
                    if (valor02 != 0)
                        resultado = valor01 / valor02;
                    else
                        Utility.WriteMessage("Erro: Divisão por zero não é permitida.");
                    break;
                default:
                    Utility.WriteMessage("Opção inválida. Escolha uma operação válida (1 a 4).");
                    break;
            }

            Utility.WriteMessage($"Resultado: {resultado}");

            Utility.TerminateConsole();

            
        }
    }
}
