﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXR19_TrocaEntreVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 19. Escrever um programa que troque entre si o valor contido em duas variáveis inteiras a e b, ou seja, o valor contidoem a passa a ser o valor de b e vice-versa, sem utilizar uma terceira variável.
             */
            int a = 4, b = 5;
            Console.WriteLine("a:{0}\tb:{1}", a, b);
            //faça execução passo a passo (F10) para ver a evolução do conteúdo das variáveis
            a = a + b; // a=9 b=5
            b = a - b; // a=9 b=4
            a = a - b; // a=5 b=4
            Console.WriteLine("a:{0}\tb:{1}", a, b);
            Console.ReadLine();
        }
    }
}
