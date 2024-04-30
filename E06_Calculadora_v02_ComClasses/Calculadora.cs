using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06_Calculadora_v02_ComClasses
{
    internal class Calculadora
    {
        public double Somar(double a, double b)
        {
            return a + b;
        }

        public double Subtrair(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
                throw new DivideByZeroException("Não é possível dividir por zero.");
        }

    }
}
