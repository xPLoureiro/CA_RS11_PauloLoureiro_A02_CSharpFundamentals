﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D13_AccessModifiers
{
    internal class User
    {
        // Field
        private DateTime registrationDate;

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


        // Constructors

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

        // Método para criar um usuário
        internal void CreateUser()
        {
            Utility.WriteTitle("Create user");

            Utility.WriteMessage("Person name: ", "\n");
            Name = Console.ReadLine();

            Utility.WriteMessage("Department: ");
            Department = Console.ReadLine();

            Utility.WriteMessage("Registration date");
            {
                DateTime registrationDate;
                string dataInserida;
                bool dataValida;

                // Todo MRS: não fazer If dentro do While
                do
                {
                    Utility.WriteMessage("(DD/MM/YYYY): ");
                    dataInserida = Console.ReadLine();
                    dataValida = DateTime.TryParse(dataInserida, out registrationDate);

                    //if (!dataValida)
                    //{
                    //    Utility.WriteMessage("A data inválida, tenta novamente: ");
                    //}
                }
                while (!dataValida);

                Utility.WriteMessage("Data validada.");

            }
            Utility.WriteMessage("Username: ");
            Username = Console.ReadLine();

            Utility.WriteMessage("Password: ");
            Password = Console.ReadLine();

        }

        // Todo MRS: terminar o método mostrando as labels e indentar corretamente
        // Método para mostrar o usuário
        internal void ListUser(string beginTitle = "")
        {
            Utility.WriteMessage(Name, beginTitle);
            Utility.WriteMessage(Department, beginTitle);
            Utility.WriteMessage(Username, beginTitle);
            Utility.WriteMessage(Password, beginTitle);
        }


        
    }
}
