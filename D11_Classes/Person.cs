/*
CLASS ELEMENTS:
        Attributes or fields    = variáveis privadas da classe (suporte às propriedades)
        Properties              = caraterísticas
        Methods                 = funcionalidades
        Constructors            = funcionalidade invocada aquando da criação do objeto
        Destructor              = funcionalidade que permite indicar como é que o objeto é destruído
    EXEMPLO
        Classe: Produto
        Objects (instâncias da classe): Produto1, Produto2, Produto3...
        Properties: Nome, Cor, Unidade, ...
        Methods: Inserir, Pesquisar, Editar, Apagar, ...
        Constructor: Cor = verde
        Destructor (log): informar que o objeto vai ser destruído 
 */


using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace D11_Classes
{
    internal class Person
    {

        #region Fields (private) // variáveis privadas das propriedades (para utilização privada das variáveis)
        private string city;        // minúsculas  (antigamente era assim _city)
        private string country;     // minúsculas
        private string address;

        #endregion


        #region Properties (public ou internal)
        

        #region Auto-implemented properties 2.0  // não é preciso declarar variáveis

        public int Id { get; set; } 
        public string Name { get; set; }
        public string Phone { get; set; }   // não se calcula é string
        public string NIF { get; set; }   // não se calcula é string
        // public string Address { get; set; }  passou a clássica
        #endregion

        #region Classic properties 1.0 (requer o Field)
        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public string City
        { 
            get { return city; }              // ler o valor da propriedade
            set { city = value; }             // escrever o valor da propriedade
                
        }


        #endregion

        #region Bodie-expression properties 3.0 (requer o Field)
        public string Country
        {
            get => country;                 // => lambda operator
            set => country = value;
        }

        #endregion


        #endregion


        #region Constructors (public ou internal)
        // Substituto do default constructor
        public Person()
        {
            Id = 0;
            Name = "";
            NIF = string.Empty;
            Phone = "";
            Address = "";
            City = "";
            Country = "";        
        }

        public Person(int id, string name, string nif, string phone, string Address, string City, string Country)
        {
            Id = id;  // isto não é um field, é o parameter que está a ser recebido
            Name = name;
            NIF = nif;
            Phone = phone;
            Address = address;
            City = city;
            Country = country;

        }

        public Person(int id, string name)
        {
            Id = id;  // isto não é um field, é o parameter que está a ser recebido
            Name = name;

        }


        #endregion

        #region Methods (public ou internal)

        // 4. Pedir os dados da pessoa (a quem compete? ler e escrever valores
        public void PersonReadData()
        {
            Utility.WriteTitle("Person - read", "\n\n");

            Utility.WriteMessage("Person id: ", "\n");
            Id = Convert.ToInt16(Console.ReadLine());            // debug, try...catch

            Utility.WriteMessage("Person name: ", "\n");
            Name = Console.ReadLine();

            Utility.WriteMessage("Person nif: ", "\n");
            NIF = Console.ReadLine();

            Utility.WriteMessage("Person phone: ", "\n");
            Phone = Console.ReadLine();

            Utility.WriteMessage("Person address: ", "\n");
            Address = Console.ReadLine();

            Utility.WriteMessage("Person city: ", "\n");
            City = Console.ReadLine();

            Utility.WriteMessage("Person country: ", "\n");
            Country = Console.ReadLine();

        }


        public void PersonWriteData() // permite criar os dados na consola
        {
            Utility.WriteTitle("Person - list", "\n\n");

            Utility.WriteMessage($"Id: {Id}", "", "\n");
            Utility.WriteMessage($"Name: {Name}", "", "\n");
            Utility.WriteMessage($"NIF: {NIF}", "", "\n");
            Utility.WriteMessage($"Phone: {Phone}", "", "\n");
            Utility.WriteMessage($"Address: {Address}", "", "\n");
            Utility.WriteMessage($"City: {City}", "", "\n");
            Utility.WriteMessage($"Country: {Country}");
        }
        #endregion


        #region Destructor


        #endregion

    }
}