using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0608_AlturaFuncionariosMaxMinMed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 8. Escrever um programa que peça a altura de n funcionários de uma empresa e apresente as seguintes estatísticas:
                • A altura do funcionário mais baixo;
                • A altura do funcionário mais alto;
                • A altura média.
             */
            int altura, alto, baixo, totalF, i, soma;
            Console.WriteLine("Quantos funcionários tem a empresa? ");
            totalF = Convert.ToInt32(Console.ReadLine());
            if (totalF > 0)
            {
                Console.WriteLine("Altura do funcionário em cm: ");
                altura = Convert.ToInt32(Console.ReadLine());
                alto = altura;
                baixo = altura;
                soma = altura;
                for (i = 1; i < totalF; i++)
                {
                    Console.WriteLine("Altura do funcionário em cm: ");
                    altura = Convert.ToInt32(Console.ReadLine());
                    if (altura > alto)
                    {
                        alto = altura;
                    }
                    if (altura < baixo)
                    {
                        baixo = altura;
                    }
                    soma = soma + altura;
                }
                Console.WriteLine("O funcionário mais alto tem {0} cm e o mais baixo tem {1} cm.",
                alto, baixo);
                Console.WriteLine("A altura média dos funcionários é de {0} cm.", soma / totalF);
                Console.ReadLine();
            }
        }
    }
}
