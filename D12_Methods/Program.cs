using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D12_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            Methods methods01 = new Methods();

            #region Método void
            Utility.WriteTitle("Procedure (método void)", "\n");

            methods01.Procedure();
            #endregion

            #region Método não void
            Utility.WriteTitle("Function (método não void)", "\n");

            // v1 não é recomendado fazer, é preferível a v2
            Utility.WriteMessage(methods01.Function().ToString(), "\n");
            //Utility.WriteMessage($"{methods01.Function()}"); // podia ser assim tb

            // v2 (pela boa prática esta é a mais correta: guarda numa variável para poder reutiliza-la + tarde)
            int res;

            res = methods01.Function();

            Utility.WriteMessage(res.ToString(), "\n");

            #endregion

            #region Método com parâmetros obrigatórios
            Utility.WriteTitle("Método com parâmetros obrigatórios", "\n");

            methods01.MethodRequiredParameters("Passagem de parâmetros.", "Obrigatórios.");
            #endregion

            #region Método com parâmetros opcionais
            Utility.WriteTitle("Método com parâmetros opcionais", "\n");

            methods01.MethodOptionalParameters("Passagem de parâmetros.");


            #endregion

            #region Método com pârametros por valor (defeito)
            Utility.WriteTitle("Método com parâmetros por valor", "\n");

            int value = 1;

            Utility.WriteMessage($"\n1. Valor antes do método:{value}", "\n"); // 1

            methods01.PassingValues(value);

            Utility.WriteMessage($"\n3. Valor depois do método:{value}", "\n"); // 1


            #endregion

            #region Método com pârametros por referência
            Utility.WriteTitle("Método com parâmetros por referência", "\n");
            
            int value02 = 1;

            Utility.WriteMessage($"1. Valor antes do método:{value02}", "\n"); // 1

            methods01.PassingReferences(ref value02);

            Utility.WriteMessage($"3. Valor depois do método:{value02}", "\n"); // 10

            #endregion


            #region Método de instância
            Utility.WriteTitle("Método de instância.", "\n");

            // Chamar o método da instância
            methods01.InstanceMethod();

            /* podemos criar nova instância em vez de aproveitard e cima
            
             
             
             
             */ 
     


            #endregion

            #region Método estático
            Utility.WriteTitle("Método estático.", "\n");

            // Chamar o método estático
            Methods.StaticMethod();

            #endregion

            #region Sobrecarga de métodos (overloading)
            Utility.WriteTitle("Overloading de métodos", "\n");

            Methods.WriteNewMessage("1º overload");
            Methods.WriteNewMessage("2º", " OVERLOAD");

            #endregion







            // Terminar

            Utility.TerminateConsole();





        }

    }
}
