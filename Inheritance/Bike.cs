using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    internal class Bike:Vehicle
    {
        public int NoOfWheels { get; set; }

        public void UseStand()
        {
            Console.WriteLine("Use stand when parked");
        }
    }
}
