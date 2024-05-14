using D00_Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07_Collections_ArrayList_Person
{
    internal class Person
    {

        #region Properties
        internal int Id { get; set; }
        internal string Name { get; set; }
        #endregion
        
        #region Constructors
        internal Person()
        {
            Id = 0;
            Name = string.Empty;
        }
        
        internal Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
        #endregion
        
        #region Methods
        internal static void ListPerson(ArrayList list)
        {
            foreach (Person item in list)
            {
                Utility.WriteMessage($"{item.Id}, {item.Name}", "", "\n");
            }
        }
        #endregion
    }
}
