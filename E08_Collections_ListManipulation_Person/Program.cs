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

            /*
            Person person01 = new Person("Manuel");
            Person person02 = new Person("Maria");
            Person person03 = new Person("José");

            listPerson.Add(person01);
            listPerson.Add(person02);
            listPerson.Add(person03);
            */

            Person person = new Person();
            string control;

            try
            {
                person.Task = PersonUtility.ShowMenu();

                if (person.Task != "8")
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
                //Utility.WriteMessage($"Deseja continuar? (y) : ", "", "\n");
                //control = Console.ReadLine();
                //if (control.ToLower() != "y")
                {
                    Utility.TerminateConsole();
                }
            }
        }
    }
}
