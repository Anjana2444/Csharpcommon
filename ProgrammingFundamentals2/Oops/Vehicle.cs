using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }
        public void Start()
        {
            Console.WriteLine($"The vehicle is starting");
        }

        public void Display()
        {
            Console.WriteLine(this.Brand);
        }
    }
}
