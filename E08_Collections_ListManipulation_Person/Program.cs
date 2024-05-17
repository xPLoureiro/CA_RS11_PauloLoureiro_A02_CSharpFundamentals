using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E08_Collections_ListManipulation_Person
{
    internal class Program
    {
        //static List<Person> listPerson = new List<Person>(); // pública à classe

        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Person person = new Person();
            string control;

            try
            {
                person.Option = PersonUtility.ShowMenu();

                if (person.Option != "8")
                {
                    person.Manipulation();
                }
            }
            catch (Exception ex)
            {
                Utility.WriteMessage($"Erro: {ex.Message}", "\n\n");
            }
            finally
            {
                Utility.WriteMessage($"For continue press 'y': ", "", "\n");
                control = Console.ReadLine();
                if (control.ToLower() != "y")
                {
                    Utility.TerminateConsole();
                }
            }
        }
    }
}
