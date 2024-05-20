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
        internal int Id { get; set; }
        internal static int NextId { get; set; } = 1;
        internal string Name { get; set; }
        internal string Option { get; set; }
        #endregion

        #region Constructors
        internal Person()
        {
            Id = NextId++;
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
            switch (Option)
            {
                case "1":
                    do
                    {
                        Utility.WriteMessage("Name:");
                        string name = Console.ReadLine();
                        AddPerson(new Person { Id = NextId++, Name = name });
                    } while (PersonUtility.ContinueOption() == "y"); 
                    break;
                case "2":
                    do
                    {
                        Utility.WriteMessage("Choose index");
                        int index = Convert.ToInt32(Console.ReadLine());
                        Utility.WriteMessage("Name");
                        Name = Console.ReadLine();
                        AddPerson(new Person());
                    } while (PersonUtility.ContinueOption() == "y");
                    break;
                case "3":
                    do
                    {
                        Utility.WriteMessage("Enter person's ID to find:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Person foundPerson = FindPersonById(id);
                        if (foundPerson != null)
                        {
                            Utility.WriteMessage($"Person found: {foundPerson.Name}");
                        }
                        else
                        {
                            Utility.WriteMessage("Person not found!");
                        }
                    } while (PersonUtility.ContinueOption() == "y");
                    break;
                case "4":
                    do
                    {
                        Utility.WriteMessage("Remove Person by Id:");
                        Id = Convert.ToInt32(Console.ReadLine());
                        if (RemovePersonById(Id))
                        {
                            Utility.WriteMessage("Person removed:");
                        }
                        else
                        {
                            Utility.WriteMessage("Not possible remove:");
                        }
                    } while (PersonUtility.ContinueOption() == "y");
                    break;
                case "5":
                    SortById();
                    break;
                case "6":
                    SortByName();
                    break;
                case "7":
                    ShowList();
                    break;
                default:
                    break;
            }
            Option = PersonUtility.ShowMenu();
        }

        internal void AddPerson(Person person)
        {
            listPerson.Add(person);

            //Console.WriteLine("Person name:");
            //Name = Console.ReadLine();
            //listPerson.Add(person);
        }

        // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.add?view=netframework-4.7.2

        internal void InsertPerson( int index, Person person)
        {
            if (index >= 0 && index <= listPerson.Count)
            {
                listPerson.Insert(index, person);
            }
        }

        // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.insert?view=netframework-4.7.2

        internal Person FindPersonById(int id)
        {
            return listPerson.FirstOrDefault(p => p.Id == id);
        }

        // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.firstordefault?view=netframework-4.7.2

        internal bool RemovePersonById(int id)
        {
            Person personToRemove = FindPersonById(id);
            return personToRemove != null && listPerson.Remove(personToRemove);

            /*
            if (personToRemove != null)
            {
                listPerson.Remove(personToRemove);
                Console.WriteLine("Removed.");
            }
            else
            {
                Console.WriteLine("Not removed");
            }
            */
        }

        //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.remove?view=netframework-4.7.2

        internal void SortById()
        {
            Utility.WriteMessage("Sort by Id");
            listPerson.Sort((p1, p2) => p1.Id.CompareTo(p2.Id));
        }

        //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=netframework-4.7.2

        internal void SortByName()
        {
            Utility.WriteMessage("Sort by name");
            listPerson.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
        }

        internal void ShowList()
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