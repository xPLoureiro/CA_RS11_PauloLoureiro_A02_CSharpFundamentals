using D00_Utility;
using System;
using System.Net.Http.Headers;

namespace E06_Calculadora_v03_ComClasses_MRS
{

    internal class Calculator
    {

        #region Fields
        private double value01;
        private double value02;
        private double v1, v2;
        #endregion

        #region Properties
        internal double Value01
        {
            get { return value01; }
            set { value01 = value; }
        }

        internal double Value02
        {
            get { return value02; }
            set { value02 = value; }
        }

        internal string Operation { get; set; }
        
        internal double Result { get; set; }
        #endregion

        #region Constructors
        internal Calculator()
        {

            Value01 = 0;
            Value02 = 0;
            Result = 0;
            Operation = "";

        }
        #endregion

        #region Methods        
        internal void ReadValues()
        {
            Console.Clear();
            Utility.WriteTitle($"Calculator - Operação escolhida: {Operation}");

            int cursorLeft = Console.CursorLeft;
            int cursorTop = Console.CursorTop;
            do
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                //Utility.WriteMessage("Value 1: ", "\n");
                Console.Write("Value 1: ");
            }
            while (!double.TryParse(Console.ReadLine(), out value01));

            Console.Clear();
            Utility.WriteTitle($"Calculator - Operação escolhida: {Operation}");

            do
            {
                //Console.SetCursorPosition(cursorLeft, cursorTop);
                //Console.Write(new string(' ', Console.WindowWidth));
                //Console.SetCursorPosition(cursorLeft, cursorTop);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Clear();
                Utility.WriteTitle($"Calculator - Operação escolhida: {Operation}");
                Utility.WriteMessage($"Value 1: {value01}");
                Console.Write("Value 2: ");
                //Utility.WriteMessage("Value 2: ", "\n\n\n\n\n");
            }
            while (!double.TryParse(Console.ReadLine(), out value02));

        }

        internal void Calculate()
        {

            switch (Operation)
            {                
                case "1":
                    Add();
                    break;
                case "2":
                    Subtract();
                    break;
                case "3":
                    Multiply();
                    break;
                case "4":
                    Divide();
                    break;
            }

        }

        internal void Add()
        {

            Result = Value01 + Value02;

            /*
                // v1
                return Value01 + Value02;

                // v2
                double result;
                result = Value01 + Value02;
                return result;
            */

        }

        internal void Subtract()
        {

            Result = Value01 - Value02;

        }

        internal void Multiply()
        {

            Result = Value01 * Value02;

        }

        internal void Divide()
        {

            if (Value02 == 0)
            {
                Result = 0;
            }
            else
            {
                Result = Value01 / Value02;
            }

        }

        internal void ShowResult()
        {

            Utility.WriteMessage($"Result: {Result}", "\n\n", "\n");

        }
        #endregion

    }

}
