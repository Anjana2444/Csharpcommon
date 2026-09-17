using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConverter
{
    internal class Converter
    {
        public int Temp { get; set; }
        public float CelciusToFahrenheit(float celcius)
        {
            float fahrenheit = (celcius * 9 / 5) + 32;
            return fahrenheit;
        }
        public void PrintTemp(float temp_in_celsius, float fahrenheit)
        {
            Console.WriteLine($"{temp_in_celsius} Celsius in Fahrenheit is {fahrenheit}");
        }
    }
}
