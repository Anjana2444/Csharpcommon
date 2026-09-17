using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    internal class Lorry : Vehicles
    {
        public int Size { get; set; }
        public void LoadDetails()
        {
            Console.WriteLine("Fully Loaded");
        }
    }
}
