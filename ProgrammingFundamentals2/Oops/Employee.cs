using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Employee:Person
    {
        public string Name { get; set; }

        public void DisplayName()
        {
            Console.WriteLine($"Name of the person: {this.Name}");
        }
    }
}
