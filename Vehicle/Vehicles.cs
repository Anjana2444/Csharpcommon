using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    internal class Vehicles
    {
        public string Brand { get; set; }
        public void Start()
        {
            Console.WriteLine("The Vehicle is on");
        }
        public void Speed()
        {
            Console.WriteLine("The Vehicle is speeding");
        }
    }
}
