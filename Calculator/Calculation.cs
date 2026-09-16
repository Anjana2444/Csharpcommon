using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class Calculation
    {
        public double addition(double x, double y)
        {
            return x + y;
        }

        public double subtraction(double x, double y)
        {
            return x - y;
        }

        public double multiplication(double x, double y)
        {
            return x * y;
        }

        public void division(double x, double y)
        {
             double val = x / y;
            Console.WriteLine($"the division value is{val}");

        }


    }
}


