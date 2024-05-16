using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E07_Collections_ArrayList_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Insert person
            string control;
            
            ArrayList listPerson = new ArrayList();

            Utility.WriteTitle("INSERT PERSON", "\n", "\n");

            do
            {
                Utility.WriteMessage($"Name: ", "", "\n");
                string name = Console.ReadLine();
                Person person = new Person(listPerson.Count + 1, name);
                listPerson.Add(person);
                Utility.WriteMessage($"Continue? (y) : ", "", "\n");
                control = Console.ReadLine();
            } while (control.ToLower() == "y");
            #endregion

            #region List person
            Utility.WriteTitle("Person - list", "\n\n\n", "\n");

            Person.ListPerson(listPerson);
            #endregion

            Utility.TerminateConsole();
        }
    }
}
