using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TemperatureConverter
{
    internal class TempConverter
    {

        public double tempConverter(double celsius)
        {
            double Fahrenheit = celsius * 9.0 / 5.0 + 32;
            return Fahrenheit;
        }
    }
}
