using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0511_ClassificacaoTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 11. Escrever um programa que leia três valores inteiros e verifique se estes podem corresponder aos lados de um triângulo. No caso de se tratar de um triângulo, deve ainda de o classificar como equilátero, isósceles ou escaleno.
             */

            // v1
            int a, b, c;
            Console.Write("Introduza o primeiro valor: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o terceiro valor: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b) // É um triângulo?
                if (a == b && a == c) // Qual é o tipo de triângulo?
                    Console.WriteLine("É um triângulo equilátero");
                else
                if (a == b || a == c || b == c)
                    Console.WriteLine("É um triângulo isósceles");
                else
                    Console.WriteLine("É um triângulo escaleno");
            else
                Console.WriteLine("Não é um triângulo");
            Console.ReadLine();

            // v2
            /*
            int a, b, c;
            Console.Write("Introduza o primeiro valor: "); // Não é feita validação, ou seja, o utilizador pode
            a = Convert.ToInt32(Console.ReadLine()); // introduzir caracteres inválidos e gerar excepções (ERROS)
            Console.Write("Introduza o segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o terceiro valor: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b) // É um triângulo?
                if (a == b) // Qual é o tipo de triângulo?
                    if (a == c)
                        Console.WriteLine("É um triângulo equilátero");
                    else
                        Console.WriteLine("É um triângulo isósceles");
                else
                    if (a == c || b == c)
                    Console.WriteLine("É um triângulo isósceles");
                    else
                    Console.WriteLine("É um triângulo escaleno");
            else
                Console.WriteLine("Não é um triângulo");
            Console.ReadLine();
            */
        }
    }
}
