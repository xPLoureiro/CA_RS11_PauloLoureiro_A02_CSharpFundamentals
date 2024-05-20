using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E08_Collections_ListManipulation_Person
{
    internal class PersonUtility
    {
        internal static string ShowMenu()
        {

            string option;
            bool founded;

            string[,] menu =
            {
                { "1", ". Add person" },
                { "2", ". Insert person in position" },
                { "3", ". Find person by id" },
                { "4", ". Remove person by id" },
                { "5", ". Sort list by id" },
                { "6", ". Sort list by name" },
                { "7", ". List person" },
                { "8", ". Exit" },
            };

            do
            {
                Console.Clear();

                Utility.WriteTitle("MENU", "", "\n");

                for (int r = 0; r < 8; r++)
                {
                    for (int c = 0; c < 2; c++)
                    {
                        Console.Write($"{menu[r, c]}");
                        //Utility.WriteMessage($"{menu[r, c]}");
                    }

                    Utility.WriteMessage("");

                }

                Utility.WriteMessage("Option > ", "\n");

                option = Console.ReadLine();

                founded = false;

                for (int i = 0; i < menu.GetLength(0); i++)
                {
                    if (menu[i, 0] == option)
                    {
                        founded = true;
                        break;
                    }
                }
            } while (!founded);

            return option;
        }
        internal static string ContinueOption()
        {
            string decision;

            Utility.WriteMessage("For continue press 'y': ", "\n");
            decision = Console.ReadLine().ToLower();

            return decision;
        }
    }
}
