using System;
using System.Collections.Generic;
using System.Text;

namespace Tempconverter
{
    internal class tempconverter
    {
        public float temp { get; set; }

        public tempconverter(int _temp)
        { this.temp = _temp; }

        public float settemperatureinKelvin(float kelvin_value, float add)
        {
            float kelvin =(kelvin_value *this.temp) + add;
            return kelvin;
        }

    }



}
