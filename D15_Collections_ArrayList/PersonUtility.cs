using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D15_Collections_ArrayList
{
    internal class PersonUtility
    {

        #region Methods
        // Métodos para listar as coleções (que não person)
        internal static void ListData(ArrayList list) // static não é preciso instanciar e não devolve
        {
            foreach (var item in list)
            {
                Utility.WriteMessage($"{item}", "", "\n");
            }

        }

        #endregion

    }
}
