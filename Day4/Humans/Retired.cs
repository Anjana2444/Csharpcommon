using System;
using System.Collections.Generic;
using System.Text;

namespace Humans
{
    internal class Retired : Person
    {
        public int Pension { get; set; }
        public void IsResting()
        {
            Console.WriteLine("Retired person is resting");
        }
    }
}
