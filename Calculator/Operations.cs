using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class Operations
    {
        public float num1 { get; set; }
        public float num2 { get; set; }
        public float Addition(float num_1, float num_2)
        {
            float sum = num_1 + num_2;
            return sum;
        }
        public float Subtraction(float num_1, float num_2)
        {
            float sum = num_1 - num_2;
            return sum;
        }
        public float Multiplication(float num_1, float num_2)
        {
            float sum = num_1 * num_2;
            return sum;
        }
        public float Division(float num_1, float num_2)
        {
            float sum = num_1 / num_2;
            return sum;
        }
        public void PrintSum(float Result)
        {
            Console.WriteLine($"Result: {Result}");
        }
    }
}
