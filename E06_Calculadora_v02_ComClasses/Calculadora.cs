using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06_Calculadora_v02_ComClasses
{
    internal class Calculadora
    {
        internal double Somar(double a, double b)
        {
            return a + b;
        }

        internal double Subtrair(double a, double b)
        {
            return a - b;
        }

        internal double Multiplicar(double a, double b)
        {
            return a * b;
        }

        internal double Dividir(double a, double b)
        {
            //if (b != 0)
             return a / b;
            //else
                //throw new DivideByZeroException("Não é possível dividir por zero.");
        }

    }
}
