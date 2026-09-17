using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    internal class Father : Human
    {
        public bool IsBearded { get; set; }
        public void Driving(string name)
        {
            Console.WriteLine($"{name} is driving the car.");
            if ( IsBearded )
            {
                Console.WriteLine("Has Beard");
            }
            else
            {
                Console.WriteLine("Has No Beard");
            }
        }
    }
}
