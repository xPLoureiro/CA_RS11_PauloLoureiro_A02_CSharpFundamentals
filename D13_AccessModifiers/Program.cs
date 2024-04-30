using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D13_AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            User user01 = new User();

            User user02 = new User(1, "José Manuel", "RH", DateTime.Today, "jm", "_#%uyg2");

            user01.CreateUser();

            Utility.PauseConsole();

            user01.ListUser();

            user02.ListUser("\n\n");

            Utility.TerminateConsole();
        }
    }
}
