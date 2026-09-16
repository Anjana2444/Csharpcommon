using System;
using System.Collections.Generic;
using System.Text;

namespace Humans
{
    internal class Unemployed : Person
    {
        public int DaysUnemployed { get; set; }
        public void JobHunt()
        {
            Console.WriteLine("Unemployed is Looking for Job");
        }
    }
}
