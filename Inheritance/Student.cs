using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Student:Person
    {
        public int StudentId { get; set; }

        public void StudentIdGeneration()
        {
            Console.WriteLine("Student: Id Generated Successfully");
        }

    }
}
