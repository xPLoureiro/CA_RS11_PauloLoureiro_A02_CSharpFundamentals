using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D15_Collections_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Classe Person:
            //      2 propriedades: Name, City
            //      2 constructores
            //      1 método: ListPerson

            Utility.SetUnicodeConsole();

            #region ArrayList: multi tipos + inteiros (só a intenção!)

            // 1. Instanciar (invocar a ArrayList)
            ArrayList listMulti = new ArrayList();
            ArrayList listIntegers = new ArrayList();   //aqui não serão só Inteiros é enganador…

            // 2. Adicionar valores de tipos diferentes (um a um)
            listMulti.Add(10);
            listMulti.Add("a");
            listMulti.Add(false);
            listMulti.Add(DateTime.Today);

            // 3. Adicionar 5 valores do tipo inteiro automaticamente
            for (int i = 0; i < 5; i++)
            {
                listIntegers.Add(i);
            }

            //listIntegers.Add("Vou dar cabo desta lista!");  // Mostrar a fraqueza do ArrayList
            listIntegers.Add(-30);
            listIntegers.Add(19);

            // 4. Quantos elementos na lista?
            Utility.WriteTitle("ArrayList Contagem", "", "\n");
            Utility.WriteMessage($"Nº de elementos - listMulti; {listMulti.Count}", "", "\n");
            Utility.WriteMessage($"Nº de elementos - listIntegers; {listIntegers.Count}", "", "\n\n");

            // 5. Listar
            Utility.WriteTitle("ArrayList - listMulti", "", "\n");
            PersonUtility.ListData(listMulti);

            Utility.WriteTitle("ArrayList - listIntegers", "", "\n");
            PersonUtility.ListData(listIntegers);

            // 6. Listar, ordenando
            Utility.WriteTitle("ArrayList - listIntegers ordenada", "", "\n");
            listIntegers.Sort();
            PersonUtility.ListData(listIntegers);
            #endregion


            #region Person
            // 1. Criar 2 pessoas
            ArrayList listPerson = new ArrayList();

            Person person01 = new Person("Maria", "Porto");    
            Person person02 = new Person("Manuel", "Lisboa");

            listPerson.Add(person01);
            listPerson.Add(person02);

            // 2. Listar
            Utility.WriteTitle("ArrayList - Person", "\n\n");

            /*
            listPerson.Add(person01);       não faz sentido
            listPerson.Add(person02);
            */

            // PersonUtility.ListData(listPerson); tb não se consegue utilizar o outro método

            Person.ListPerson(listPerson);
            #endregion

            Utility.TerminateConsole();




        }
    }
}
