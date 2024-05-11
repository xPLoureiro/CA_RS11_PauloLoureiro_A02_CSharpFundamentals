using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0514_Zodiaco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 14. Escrever um programa que determine o símbolo do zodíaco de uma pessoa baseando-se no dia e no mês do seu nascimento.
             */
            /*
            // v1
            int dia, mes;
            Console.Write("Introduza o dia de nascimento: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza nº do mês de nascimento: ");
            mes = Convert.ToInt32(Console.ReadLine());
            switch (mes)
            {
                case 1:
                    if (dia < 20)
                        Console.WriteLine("Capricórnio");
                    else
                        Console.WriteLine("Aquário");
                    break;
                case 2:
                    if (dia < 19)
                        Console.WriteLine("Aquário");
                    else
                        Console.WriteLine("Peixes");
                    break;
                case 3:
                    if (dia < 21)
                        Console.WriteLine("Peixes");
                    else
                        Console.WriteLine("Carneiro");
                    break;
                case 4:
                    if (dia < 21)
                        Console.WriteLine("Carneiro");
                    else
                        Console.WriteLine("Touro");
                    break;
                case 5:
                    if (dia < 21)
                        Console.WriteLine("Touro");
                    else
                        Console.WriteLine("Gémeos");
                    break;
                case 6:
                    if (dia < 21)
                        Console.WriteLine("Gémeos");
                    else
                        Console.WriteLine("Caranguejo");
                    break;
                case 7:
                    if (dia < 22)
                        Console.WriteLine("Caranguejo");
                    else
                        Console.WriteLine("Leão");
                    break;
                case 8:
                    if (dia < 23)
                        Console.WriteLine("Leão");
                    else
                        Console.WriteLine("Virgem");
                    break;
                case 9:
                    if (dia < 23)
                        Console.WriteLine("Virgem");
                    else
                        Console.WriteLine("Balança");
                    break;
                case 10:
                    if (dia < 23)
                        Console.WriteLine("Balança");
                    else
                        Console.WriteLine("Escorpião");
                    break;
                case 11:
                    if (dia < 22)
                        Console.WriteLine("Escorpião");
                    else
                        Console.WriteLine("Sagitário");
                    break;
                case 12:
                    if (dia < 22)
                        Console.WriteLine("Sagitário");
                    else
                        Console.WriteLine("Capricórnio");
                    break;
                default:
                    Console.WriteLine("Data inválida");
                    break;
            }
            Console.ReadLine();
            */

            // v2
            int dia, mes;
            Console.Write("Introduza o dia de nascimento: "); // Não é feita validação, ou seja,o utilizador pode introduzir caracteres inválidos e gerar excepções(ERROS)
            dia = Convert.ToInt32(Console.ReadLine()); // 
            Console.Write("Introduza o mês de nascimento: ");
            mes = Convert.ToInt32(Console.ReadLine());
            if ((mes == 1 && dia >= 20 && dia <= 31) || (mes == 2 && dia >= 1 && dia <= 18))
                Console.WriteLine("Aquário");
            else
            if ((mes == 2 && dia >= 19 && dia <= 29) || (mes == 3 && dia >= 1 && dia <= 20))
                Console.WriteLine("Peixes");
            else
            if ((mes == 3 && dia >= 21 && dia <= 31) || (mes == 4 && dia >= 1 && dia <=
            19))
                Console.WriteLine("Carneiro");
            else
            if ((mes == 4 && dia >= 21 && dia <= 30) || (mes == 5 && dia >= 1 && dia
            <= 20))
                Console.WriteLine("Touro");
            else
            if ((mes == 5 && dia >= 21 && dia <= 31) || (mes == 6 && dia >= 1 &&
            dia <= 20))
                Console.WriteLine("Gémeos");
            else
            if ((mes == 6 && dia >= 21 && dia <= 30) || (mes == 7 && dia >= 1
            && dia <= 21))
                Console.WriteLine("Caranguejo");
            else
            if ((mes == 7 && dia >= 22 && dia <= 31) || (mes == 8 && dia
            >= 1 && dia <= 22))
                Console.WriteLine("Leão");
            else
            if ((mes == 8 && dia >= 23 && dia <= 31) || (mes == 9 &&
            dia >= 1 && dia <= 22))
                Console.WriteLine("Virgem");
            else
            if ((mes == 9 && dia >= 23 && dia <= 30) || (mes == 10
            && dia >= 1 && dia <= 22))
                Console.WriteLine("Balança");
            else
            if ((mes == 10 && dia >= 23 && dia <= 31) || (mes
            == 11 && dia >= 1 && dia <= 21))
                Console.WriteLine("Escorpião");
            else
            if ((mes == 11 && dia >= 22 && dia <= 30) ||
            (mes == 12 && dia >= 1 && dia <= 21))
                Console.WriteLine("Sagitário");
            else
            if ((mes == 12 && dia >= 22 && dia <= 31)
            || (mes == 1 && dia >= 1 && dia <= 20))
            Console.WriteLine("Capricórnio");
            else
                Console.WriteLine("Data inválida");
            Console.ReadLine();
        }
    }
}
