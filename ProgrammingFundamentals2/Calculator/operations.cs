using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class operations
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public operations(int _num1, int _num2)
        {
            this.Num1 = _num1;
            this.Num2 = _num2;
        }

        //public int display()
        //    {
        //        Console.WriteLine("Enter the 1st number: ");
        //string value1 = Console.ReadLine();
        //        Console.WriteLine(value1);
        //float val1 = float.Parse(value1);

        //        Console.WriteLine("Enter the 2nd number: ");
        //string value2 = Console.ReadLine();
        //        Console.WriteLine(value2);
        //float val2 = float.Parse(value2);

        //        return val1, val2;
        //    }

        //public (int sum, int product, int difference) ArithmeticOperations()
        //{
        //    int sum = this.Num1 + this.Num2;

        //    int difference;

        //    if (Num1 > Num2)
        //    { difference = this.Num1 - this.Num2; }

        //    else
        //    { difference = this.Num2 - this.Num1; }

        //    int product = this.Num1 * this.Num2;

        //    return (sum, product, difference);

        //}

        public int Sum()
        {
            int sum = this.Num1 + this.Num2;
            return sum;
        }

        public int difference()
        {
            int difference;

            if (Num1 > Num2)
            { difference = this.Num1 - this.Num2; }

            else
            { difference = this.Num2 - this.Num1; }

            return difference;
        }

        public int product()
        {
            int product = this.Num1 * this.Num2;

            return product;


        }
    }
}
