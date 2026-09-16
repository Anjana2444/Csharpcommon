using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Vehicle
    {
        public string BrandName { get; set; }
        public double speed { get; set; }

        public void start() 
        { 
        Console.WriteLine("Vehicle started.");
        }
    }


}
