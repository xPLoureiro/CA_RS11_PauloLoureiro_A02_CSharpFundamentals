using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D00_Utility
{
    public class Utility
    {

        public static void SetUnicodeConsole()
        {
            //Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");

        }

        // parameter vs argument
        public static void WriteTitle(string title)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(new string ('-', 60));    // para substituir "-------------------"

            Console.WriteLine(title.ToUpper());

            Console.WriteLine(new string('-', 60));     // para substituir "-------------------"

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();

        }


        // Escrever 1 método com 3 parameters

        public static void WriteMessage(string message, string beginMessage = "", string endMessage = "")
        {
            /*
            Console.Write(beginMessage);
            Console.Write(message);
            Console.Write(endMessage);
            */

            Console.WriteLine($"{beginMessage}{message}{endMessage}");



        }
        public static void TerminateConsole()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("\n\n\n\nPrime qualquer tecla para terminares.");

            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();

            Console.Clear();
        }
    }


}
