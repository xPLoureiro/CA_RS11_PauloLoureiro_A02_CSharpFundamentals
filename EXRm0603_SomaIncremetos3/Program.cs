using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0603_SomaIncremetos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 3. Escreva um programa que calcule a soma, com incrementos de 3, de todos os números menores que 100, começando em 4 (ex.: 4+7+10+13+...), utilizando as três estruturas de repetição que conhece.
             * DESAFIO: Em que situação um ciclo WHILE e DO…WHILE não são equivalentes?
            Por exemplo: se inicializar a variável (i), por qualquer motivo a 400…qual é a diferença?
            No caso do WHILE o resultado é diferente do DO…WHILE;
            No 1º o ciclo não executa, para logo na condição; No 2º o ciclo executa, pelo menos uma vez!
             */
            int i, soma;
            soma = 0;
            for (i = 4; i < 100; i += 3)
                soma += i;
            Console.WriteLine("Soma:{0}", soma);
            soma = 0; //Após a execução do ciclo for é necessário repor os valores das variáveis soma e i
            i = 4;
            while (i < 100)
            {
                soma += i;
                i += 3;
            }
            Console.WriteLine("Soma:{0}", soma);
            soma = 0;//Após a execução do ciclo while é necessário repor os valores das variáveis soma e i
            i = 4;
            do
            {
                soma += i;
                i += 3;
            } while (i < 100);
            Console.WriteLine("Soma:{0}", soma);

        }
    }
}
