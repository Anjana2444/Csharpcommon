using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Bike:Vehicle
    {
        public bool HasCarrier { get; set; }
        public void UseStand()
        {
            Console.WriteLine("Bike stand used.");
        }   
    }
}
