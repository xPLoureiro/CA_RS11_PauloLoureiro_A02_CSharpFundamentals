using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D06_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region 1. Declarar variáveis e criar objetos
            byte idade;     // 0 - 255
            float altura;
            double peso;

            bool inscrito; // true (1) | false (0)


            DateTime data;
            DateTime hora;
            DateTime agora;
            DateTime dataAtual;
            DateTime dataVazia;

            string nomeCompleto;    // objecto!!! (qd o Main terminar, as outras terminam e esta continua activo no garbage
            #endregion

            #region 2. Atribuir valores
            // números
            idade = 10;
            altura = 20.5F;
            peso = 10.5;

            // booleano
            inscrito = true;

            // datas
            data = new DateTime(2024, 4, 1);
            hora = new DateTime(2024, 4, 1, 19, 5, 0);
            agora = DateTime.Now;           // timestamp: data + hora
            dataAtual = DateTime.Today;     // data
            dataVazia = DateTime.MinValue;  // 1/1/0001 12:00:00 AM

            // string
            nomeCompleto = "m";
            #endregion

            #region 3. Declarar e atribuir
            string horario = "19:00 - 22:30";

            #endregion

            #region 4. Vetores (array single dimensional)
            // 4 nomes
            string[] nomes = new string[4]; //4 linhas, començando em 0
            int[] numeros = new int[4];     //4 linhas, començando em 0

            nomes[0] = "Ana";
            nomes[1] = "Milena";
            nomes[2] = "Amélia";
            Utility.WriteMessage("Apelido: ");

            nomes[3] = Console.ReadLine();  // obtem o nome inserido pelo utilizador na consola

            Utility.WriteTitle("Vetor");

            Utility.WriteMessage(nomes[0]);     // podia ser 1 a 1, mas é preferível concatenar
            Utility.WriteMessage(nomes[1]);
            Utility.WriteMessage(nomes[2]);
            Utility.WriteMessage(nomes[3]);

            Utility.WriteMessage($"{nomes[0]} {nomes[1]} {nomes[2]} {nomes[3]}");

            // Atribui valores ao vetor
            for (int i = 0; i < 4; i++)     // usar tamanho dinâmico
            {
                numeros[i] = i;
            }

            // Escrever na consola
            for (int i = 0; i < numeros.Length; i++)    // usamos tamanho dinâmico
            {
                Utility.WriteMessage($"Valor {i}: {numeros[i]}");
            }



            #endregion

            #region 5. Matrizes (array multi dimentional)

            // Atribui valores à matriz
            string[,] turma = new string[4, 2];

            turma[0, 0] = "Ana";
            turma[0, 1] = "Porto";
            turma[1, 0] = "Milena";
            turma[1, 1] = "Espinho";
            turma[2, 0] = "Amélia";
            turma[2, 1] = "Braga";

            turma[3, 0] = Console.ReadLine();           // ReadLine() lê string
            turma[3, 0] = Console.Read().ToString();    // Read() lê int, logo tem de ser convertido
            //turma[3, 1] = Convert.ToString(Console.Read());

            // Listar a matriz usando 2 FOR
            // Percorre as linhas
            for (int l = 0; l < 4; l++)    // usamos tamanho dinâmico
            {
                // Percorre as colunas
                for (int c = 0; c < 2; c++)    // usamos tamanho dinâmico
                {
                    // ir ver exemplos


                }



            }




            #endregion

            #region 6. Trabalhar ca consola

            #region Números (Não corrigir para usar o Utility)

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Variáveis numéricas");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("\nByte - idade: " + idade);  // Não concatenar com o +

            // string interpolation: safe concatenation
            Console.WriteLine($"Float - altura: {altura}");
            Console.WriteLine($"Double - peso: {peso}\n\n\n");
            // fim
            #endregion

            #region Boolean
            // Usar o Utility ---------------------------------------------

            Utility.WriteTitle("Variável booleana");

            Console.WriteLine($"\nBoolean - inscrito: {inscrito}\n\n\n");


            Utility.WriteTitle("Variável string");

            // as strings são imutáveis (é um endereço de memória na heap)
            // Deve-se concatenar strings com a classe StringBuilder e o método Add
            nomeCompleto = nomeCompleto + " rs"; // concatenação: m + rs = m rs
            Console.WriteLine($"String - nome completo: {nomeCompleto}", "\n");
            Console.WriteLine($"String - horário: {horario}\n\n\n");

            #endregion

            #region DateTime

            Utility.WriteTitle("Variáveis data e hora");

            // Console.WriteLine($"\n0.Date - data: {data}"); 

            Utility.WriteMessage($"Date - data: {data}", "\n");
            Utility.WriteMessage($"2. Date - data: {data}", "", "\n\n\n");
            Utility.WriteMessage($"3. Date - data: {data}", beginMessage: "\n\n\n");
            Utility.WriteMessage($"4. Date - data: {data}", "\n\n", "\n\n\n");
            Utility.WriteMessage($"5. Date - data: {data}");

            // agora vai-se substutir o WriteLine pelo WriteMessage

            // Console.WriteLine($"\nDate - data: {data}");
            Utility.WriteMessage($"Date - data: {data}", "\n");

            //Console.WriteLine($"Long date - data: {data.ToLongDateString()}");
            Utility.WriteMessage($"Long date - data: {data.ToLongDateString()}");


            //Console.WriteLine($"Short date - data: {data.ToShortDateString()}");
            Utility.WriteMessage($"Short date - data: {data.ToShortDateString()}");

            //Console.WriteLine($"Time - horas: {hora}");
            Utility.WriteMessage($"Time - horas: {hora}");

            //Console.WriteLine($"Long time - horas: {hora.ToLongTimeString()}");
            Console.WriteLine($"Long time - horas: {hora.ToLongTimeString()}");

            //...
            Utility.WriteMessage($"Short - horas: {hora.ToShortTimeString()}");

            Utility.WriteMessage($"Date - agora: {agora}");
            Utility.WriteMessage($"Date - data atual: {dataAtual}");
            Utility.WriteMessage($"Date - data vazia: {dataVazia}");

            Utility.WriteMessage($"Year - agora; {agora.Year}");
            Utility.WriteMessage($"Month - agora; {agora.Month}");
            Utility.WriteMessage($"Day - agora; {agora.Day}");
            Utility.WriteMessage($"Hour - agora; {agora.Hour}");
            Utility.WriteMessage($"Minute - agora; {agora.Minute}");
            Utility.WriteMessage($"Second - agora; {agora.Second}");


            Utility.TerminateConsole();

            #endregion

            #endregion

            //Console.ReadKey();



        }
    }
}
