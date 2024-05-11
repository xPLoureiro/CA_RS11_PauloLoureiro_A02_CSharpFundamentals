using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0504_SalarioHorasExtra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 4. Escrever um programa para calcular o salário semanal a pagar a um empregado, tendo em atenção que todas as horas após as 40 serão pagas a dobrar. O utilizador deve de indicar o valor do salário por hora e o valor das horas trabalhadas.
             */
            float horas, salarioHora, salario;
            Console.Write("Introduza um número de horas trabalhadas: ");
            horas = Convert.ToSingle(Console.ReadLine());
            Console.Write("Introduza o valor do salário por hora: ");
            salarioHora = Convert.ToSingle(Console.ReadLine());
            if (horas <= 40) // Foram trabalhadas menos de 40 horas?
            {
                salario = horas * salarioHora; // Não há horas extraordinárias
            }
            else
            {
                salario = 40 * salarioHora + (horas - 40) * salarioHora * 2;
                // As primeiras 40 horas são pagas ao preço normal --> (40 * sh),
                //as horas para além das 40 -->(horas - 40), são pagas a dobrar --> (salarioHora * 2)
                // alternativa à instrução anterior --> salario = salarioHora*(2*horas-40)
                Console.WriteLine("Salário semanal: {0}", salario);
                Console.ReadLine();
            }
        }
    }
}
