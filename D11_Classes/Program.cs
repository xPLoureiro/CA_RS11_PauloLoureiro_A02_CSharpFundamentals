using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D11_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            // 1. Instanciar a classe Person e atribuir os valores
            Person person01 = new Person();     // método construtor vazio e à posteriori inserimos os dados, já existia antes de ter dados

            person01.Id = 1;
            person01.Name = "Pessoa 1";
            person01.NIF = "123456789";
            person01.Phone = "123456789";
            person01.Address = "Rua Aqui, 10";
            person01.City = "Cidade Sei Lá?";
            person01.Country = "Será?";

            // 2. Instanciar a classe Person com o 3º constructor

            Person person02 = new Person(2, "Pessoa 2");

            // 3. Instanciar a classe Person e imediatamente passar os valores, com o 2º constructor
            
            Person person03 = new Person(3, "Pessoa 3", "123456789", "321321321", "Rua de lá", "Av. Qaz 1", "PT");


            // 4. Usar os métodos
            Person person04 = new Person();

            person04.PersonReadData();
            person04.PersonWriteData();


            // 5. Terminar

            Utility.TerminateConsole();


        }
    }
}
