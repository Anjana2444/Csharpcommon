using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConverter
{
    internal class Converter
    {
        public int Celsius { get; set; }

        public float ConvertToFahrenheit(float celsius_value) { 
            float fahrenheit_value = (celsius_value*9/5) + 32;
            return fahrenheit_value;
        }

        public void PrintCelsiusAndFahrenheit(float fahrenheit_value, float celsius_value)
        {
            Console.WriteLine($"Celsius: {celsius_value}, Fahrenheit: {fahrenheit_value}");
        }

    }
}


