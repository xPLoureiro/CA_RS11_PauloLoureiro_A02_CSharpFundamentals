using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using D00_Utility;

namespace E08_Collections_ListManipulation_Person
{
    internal class Person
    {
        #region Properties
        internal static int NextId { get; set; } = 1;
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal string Task { get; set; }
        #endregion

        #region Constructors
        internal Person()
        {
            Id = 0;
            Name = string.Empty;
        }

        internal Person(string name)
        {
            Id = NextId++;
            Name = name;
        }
        #endregion

        List<Person> listPerson = new List<Person>();

        #region Methods
        internal void Manipulation()
        {
            switch (Task)
            {
                case "1":
                    AddPerson(listPerson);
                    break;
                case "2":
                    //InsertPerson(listPerson);
                    break;
                case "3":
                    Console.WriteLine("Enter person's ID to find:");
                    Id = Convert.ToInt32(Console.ReadLine());
                    Person foundPerson = FindById(listPerson, Id);
                    if (foundPerson != null)
                    {
                        Console.WriteLine($"Person found: {foundPerson.Name}");
                    }
                    else
                    {
                        Console.WriteLine("Person not found!");
                    }
                    break;
                case "4":
                    Console.WriteLine("Remove Person by Id:");
                    int idToRemove = Convert.ToInt32(Console.ReadLine());
                    RemovePersonById(listPerson, Id);
                    break;
                case "5":
                    SortById(listPerson);
                    break;
                case "6":
                    SortByName(listPerson);
                    break;
                case "7":
                    ShowList(listPerson);
                    break;
            }
        }

        internal static void AddPerson(List<Person> listPerson, Person person)
        {
            person.Id = NextId++;
            Console.WriteLine("Person name:");
            person.Name = Console.ReadLine();
            listPerson.Add(person);
        }

        // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.add?view=netframework-4.7.2

        internal static void InsertPerson(List<Person> listPerson, int index, Person person)
        {
            Console.WriteLine("Index:");
            index = Convert.ToInt32(Console.ReadLine());
            if (index >= 0 && index <= listPerson.Count)
            {
                person.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Person name:");
                person.Name = Console.ReadLine();
                listPerson.Insert(index, person);
            }
            else
            {
                Console.WriteLine("Index not found!");
            }
        }

        // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.insert?view=netframework-4.7.2

        internal static Person FindById(List<Person> listPeople, int id)
        {
            return listPeople.FirstOrDefault(p => p.Id == id);
        }

        // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.find?view=netframework-4.7.2

        internal static void RemovePersonById(List<Person> listPerson, int Id)
        {
            Person personToRemove = FindById(listPerson, Id);
            if (personToRemove != null)
            {
                listPerson.Remove(personToRemove);
                Console.WriteLine("Removed.");
            }
            else
            {
                Console.WriteLine("Not removed");
            }
        }

        //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.remove?view=netframework-4.7.2

        internal static void SortById(List<Person> listPerson)
        {
            Utility.WriteMessage("Sort by Id");
            listPerson.Sort((p1, p2) => p1.Id.CompareTo(p2.Id));
        }

        //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=netframework-4.7.2

        internal static void SortByName(List<Person> listPerson)
        {
            Utility.WriteMessage("Sort by name");
            listPerson.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
        }

        internal static void ShowList(List<Person> listPerson)
        {
            if (listPerson.Count == 0)
            {
                Utility.WriteMessage("Empty list");
            }
            else
            Utility.WriteMessage("List:");
            
            foreach (Person item in listPerson)
            {
                Utility.WriteMessage($" Id - Name {item.Id} - {item.Name}", "", "\n");
            }
        }
        #endregion




    }
}