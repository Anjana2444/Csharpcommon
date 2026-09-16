using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Employee:Person
    {
        public int EmployeeId { get; set; }

        public void EmployeeIdGeneration()
        {
            Console.WriteLine("Employee: Id Generated Successfully");
        }
    }
}
