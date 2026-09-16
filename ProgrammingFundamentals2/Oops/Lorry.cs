using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Lorry:Vehicle
    {
        public string size { get; set; }

        public void EmergencyLight()
        {
            Console.WriteLine("Switch on the emergency light when riding through fog");
        }
    }
}
