using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D14_ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Error handling");

            #region Sem tratamento de erros
            /*
            int number01;
            Utility.WriteMessage("Insere um número inteiro: ");
            number01 = Convert.ToInt16(Console.ReadLine());
            */
            #endregion

            #region Com tratamento de erros
            try
            {
                int number02;
                Utility.WriteMessage("Insere um número inteiro: ");
                number02 = Convert.ToInt16(Console.ReadLine());
            }
            catch (DivideByZeroException ex)
            {
                Utility.WriteMessage("Não podes dividir por zero.");
            }
            catch (FormatException ex)
            { 
                Utility.WriteMessage("Escreve um número."); 
            }
            catch (Exception ex)  // se der erro, gera um objeto em runtime (na versão de produção) 
            {

                // versão de desenvolvimento
                // throw; lança o erro para a consola (na versão de desenvolvimento)

                Utility.WriteMessage($"Erro: {ex.Message}");

                // versão de produção (devemos implementar um sistema de logs)
                // Utility.WriteMessage("Aconteceu um erro.", "\n", "\n\n");
            }
            finally // é sempre executado
            {
                Utility.WriteMessage("Terminei!");
            }

            #endregion

            Utility.TerminateConsole();


        }
    }
}
