﻿using System;
using System.Collections.ObjectModel;
using D00_Utility;

namespace D10_LoopStructures
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region Variáveis
            string string01 = "";
            string string02 = "x";
            string name = string.Empty;
            #endregion

            #region WHILE (enquanto)
            // O teste é feito no início
            // Não garante que seja feito uma única vez

            Utility.WriteTitle("WHILE");

            while (string01 != "x")
            {
                Utility.WriteMessage("Para saíres escreve x: ", "\n");
                string01 = Console.ReadLine();
            }

            Utility.TerminateConsole();

            #endregion

            #region DO...WHILE (repetir até)
            // O teste é feito no fim
            // Garante que é feito pelo menos 1 vez
            Utility.WriteTitle("DO...WHILE");

            do
            {
                Utility.WriteMessage("Para saíres escreve x: ", "\n");
                string02 = Console.ReadLine();
            } while (string02 != "x");

            Utility.TerminateConsole();
            #endregion

            #region FOR (para)
            // Repetir x número de vezes
            Utility.WriteTitle("FOR");

            // asc
            for (int i = 0; i < 3; i++)    // i++    i = i + 1
            {
                Utility.WriteMessage($"i = {i}\n");
            }

            Utility.WriteMessage("\n");

            // desc
            for (int i = 2; i >= 0; i--)    // i--  i = i - 1
            {
                Utility.WriteMessage($"i = {i}\n");
            }

            Utility.TerminateConsole();
            #endregion

            #region FOREACH (para cada elemento)
            // Percorrer todos os elementos dum array ou duma collection

            int[] numeros = { 3, 10, 1, 20, 0, 4 };     // LINQ
            
            foreach (int item in numeros)
            {
                Utility.WriteMessage(item.ToString(), "\n");
            }
            #endregion

            Utility.TerminateConsole();

        }

    }

}
