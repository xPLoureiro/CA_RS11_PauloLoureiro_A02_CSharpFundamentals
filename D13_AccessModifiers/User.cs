using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D13_AccessModifiers
{
    internal class User
    {
        #region Fields
        // Field
        private DateTime registrationDate;  // suporte à propriedade RegistrationDate
        #endregion

        #region Properties
        // Declarar uma propriedade usando Auto-implemented properties
        internal int Id { get; }      // read-only
        internal string Name { get; set; }
        internal string Department { get; set; }
        // declarar uma propriedade usando Classic properties
        internal DateTime RegistrationDate
        {
            get { return registrationDate; }    // ler o valor da propriedade
            set { registrationDate = value; }   // escrever o valor da propriedade
        }
        internal string Username { get; set; }
        internal string Password { get; set; }
        #endregion

        #region Constructors

        // Susbtituto do default constructor
        internal User()
        {
            Id = 1;
            Name = string.Empty;
            Department = string.Empty;
            RegistrationDate = new DateTime();  // ou RegistrationDate = DateTime.MinValue;
            Username = string.Empty;
            Password = string.Empty;
        }

        // 2º constructor com inserção de parâmetros obrigatórios
        internal User(int id, string name, string department, DateTime registrationDate, string username, string password)
        {
            Id = id;
            Name = name;
            Department = department;
            RegistrationDate = registrationDate;
            Username = username;
            Password = password;
        }
        #endregion

        #region Methods
        // Método para criar um usuário
        internal void CreateUser()
        {
            Utility.WriteTitle("Create user");

            Utility.WriteMessage("Person name: ", "\n");
            Name = Console.ReadLine();

            Utility.WriteMessage("Department: ");
            Department = Console.ReadLine();

            Utility.WriteMessage("Registration date");

            // validar o imput e não avançar enquanto não for data
            // usar: TryParse e no out usar o field
            // okToDo MRS: não fazer If dentro do While --ok20240501PL
            while (!DateTime.TryParse(Console.ReadLine(), out registrationDate))
            {
                Utility.WriteMessage("Inserir uma data válida (ex. 29/04/2024): ");
            }
            
            Utility.WriteMessage("Username: ");
            Username = Console.ReadLine();

            Utility.WriteMessage("Password: ");
            Password = Console.ReadLine();

        }

        // okTodo MRS: terminar o método mostrando as labels e indentar corretamente --ok20240501PL
        // Método para mostrar o usuário
        internal void ListUser(string beginTitle = "")
        {
            Utility.WriteTitle("List user", beginTitle);

            Utility.WriteMessage($"Person Id: {Id}", "\n", "\n");
            Utility.WriteMessage($"Person name: {Name}", "", "\n");
            Utility.WriteMessage($"Department: {Department}", "", "\n");
            Utility.WriteMessage($"Registration date: {RegistrationDate.ToShortDateString()}", "", "\n");
            Utility.WriteMessage($"Username: {Username}", "", "\n");
            // Utility.WriteMessage($"Password: {Password}"); // mostra password
            Utility.WriteMessage($"Password: {OcultarPassword(Password)}");
        }

        // Método para retornar * em vez dos carateres da password
        internal string OcultarPassword(string password)
        {
            return new string('*', password.Length);
        }

        #endregion
    }
}
