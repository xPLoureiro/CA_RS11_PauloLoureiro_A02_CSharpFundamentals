using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXR12_ConversaoTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * 12. Escreva um programa que converta a temperatura lida em graus Fahrenheit para graus Celsius. A fórmula é C = 5/9 *(f - 32).
             */
            float f;
            Console.Write("Introduza a temperatura em graus Farenheit: ");
            // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            f = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("{0}°F={1:F2}°C", f, 5/9F * (f - 32));
            //Console.WriteLine("{0}°F={1:F2}°C", f, 5.0/9 * (f - 32));
            //A divisão 5/9F é real porque 9 é do tipo float, sem a letra F a divisão seria inteira e conduziria a um resultado errado
            // Para que a divisão 5/9 seja real o numerador ou o denominador têm que ser reais
            Console.ReadLine();
            

            /* v1:
            Console.Write("Introduza a temperatura em graus Farenheit: ");
            float fahrenheit = Convert.ToSingle(Console.ReadLine());
            float celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"A temperatura em graus Celsius é: {celsius.ToString("F2")}ºC");
            Console.ReadLine();
            */
            
        }
    }
}
