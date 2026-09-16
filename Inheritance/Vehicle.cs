using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    internal class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public void Start()
        {
            Console.WriteLine($"The vehicle is starting.");
        }
    }
}
