using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    internal class Mother : Human
    {
        public bool HasShortHair { get; set; }
        public void Working(string name)
        {
            Console.WriteLine($"{name} is working in the office");
            if (HasShortHair)
            {
                Console.WriteLine("Has Short Hair");
            }
            else
            {
                Console.WriteLine("Has Long Hair");
            }
        }
    }
}
