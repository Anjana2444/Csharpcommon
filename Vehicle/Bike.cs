using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    internal class Bike : Vehicles
    {
        public int NumberOfTyres { get; set; }
        public void UseStand()
        {
            Console.WriteLine("Stand Used");
        }
    }
}
