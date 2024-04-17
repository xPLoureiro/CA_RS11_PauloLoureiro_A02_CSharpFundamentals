using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D09_ConditionalStructures
{

    internal class Program
    {

        static void Main(string[] args)
        {
            
            Utility.SetUnicodeConsole();

            #region Variáveis
            int numero = 0;
            int valor01 = 1;
            int valor02 = 2;
            bool resultado = true;
            #endregion

            #region If Simples
            Utility.WriteTitle("If Simples");

            if (numero == 0)
            {
                Utility.WriteMessage("O número é 0.");
            }

            if (numero == 10)
            {
                Utility.WriteMessage("O número é 10.");
            }
            #endregion

            #region If Else
            Utility.WriteTitle("If Else");

            if (numero == 100)
            {
                Utility.WriteMessage("O número é igual a 100.");
            }
            else
            {
                Console.WriteLine("O número é diferente de 100.");
            }
            #endregion

            #region Operador Ternário
            Utility.WriteTitle("Operador Ternário");

            /* Clássico
            if (valor01 == valor02)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            */

            // Se 2 valores são iguais           
            resultado = valor01 == valor02 ? true : false;      // result = expression ? T : F

            Utility.WriteMessage(resultado.ToString());
            #endregion

            #region Ifs Encadeados

            #endregion

            #region If ElseIf

            #endregion

            #region Switch
            // ToDo MRS: Se o nº for entre 1 e 4 dizer o seu extendo
            #endregion

            Utility.TerminateConsole();

        }

    }

}
