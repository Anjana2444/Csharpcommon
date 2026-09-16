using System;
using System.Collections.Generic;
using System.Text;

namespace Humans
{
    internal class Student : Person
    {
        public string Course { get; set; }
        public void IsStudy()
        {
            Console.WriteLine("Student is Studying");
        }
    }
}
