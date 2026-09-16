using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class Employee
    {
        public string name;
        public int id;
        public float salary;
        public void show()
        {
            Console.WriteLine("This Function is used to display");
        }

        public Employee(string First_name, int id, float salary)
        {
            name = First_name;
            this.id = id;
            this.salary = salary;
        }

        internal class Department:Employee
        {

        }


    }
}
