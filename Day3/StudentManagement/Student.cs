using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement
{
    internal class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }

        public Student(int rollNumber, string name)
        {
            this.RollNumber = rollNumber;
            this.Name = name;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Roll Number : {this.RollNumber}");
            Console.WriteLine($"Name : {this.Name}");
        }
    }
}
