using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Plane: Vehicle
    {
        public string BaseAirport { get; set; }

        public void TakeOff()
        {
            Console.WriteLine("Plane is taking off.");
        }
    }
}
