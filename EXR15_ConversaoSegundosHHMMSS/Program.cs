﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXR15_ConversaoSegundosHHMMSS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             15. Escrever um programa que converta um valor em segundos para horas, minutos e segundos.
             */
            int ss, s, m, h;
            Console.Write("Introduza o número de segundos: ");
            // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            ss = Convert.ToInt32(Console.ReadLine());
            // Todas as divisões efectuadas neste exercício são divisões inteiras
            s = ss % 60; // segundos - % : resto da divisão inteira
            m = (ss / 60) % 60; // minutos
            h = (ss / 60) / 60; // horas
            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", h, m, s);
            Console.ReadLine();
        }
    }
}