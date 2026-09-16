using System;
using System.Collections.Generic;
using System.Text;

namespace Humans
{
    internal class Employee : Person
    {
        public string JobTitle {  get; set; }
        public void IsWorking()
        {
            Console.WriteLine("Employee is working");
        }
    }
}
