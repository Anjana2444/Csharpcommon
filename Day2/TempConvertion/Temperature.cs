using System;
using System.Collections.Generic;
using System.Text;

namespace TempConvertion
{
    internal class Temperature
    {
        public float Value { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"Temperature: {this.Value}");
        }

        public float CelsiusToFahrenheit()
        {
            float fahrenheit = (this.Value * 9/5) + 32;
            return fahrenheit;
        }
    }
}
