using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorPgm
{
    internal class Calculator
    {
        public float Number1 { get; set; }
        public float Number2 { get; set; }

        public Calculator(float number1,float number2)
        {
            this.Number1 = number1;
            this.Number2 = number2;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Number 1: {this.Number1}");
            Console.WriteLine($"Number 2: {this.Number2}");
        }

        public float Add()
        {
            float result = this.Number1 + this.Number2;
            return result;
        }
        public float Sub()
        {
            float result = this.Number1 - this.Number2;
            return result;
        }
        public float Mult()
        {
            float result = this.Number1 * this.Number2;
            return result;
        }
        public float Div()
        {
            float result = this.Number1 / this.Number2;
            return result;
        }
    }
}
