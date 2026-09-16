using System;
using System.Collections.Generic;
using System.Text;

namespace college
{
    internal class Details
    {
        public int StdId { get; set; }
        public string StudentName { get; set; }
        public int Marks { get; set; }

        //public Details(int id,string name,int marks)
        //    {
        //    this.StdId = id;
        //    this.StudentName = name;
        //    this.Marks = marks;

        ////}

        public void Display()
        {
            Console.WriteLine($"Id:{StdId}");
            Console.WriteLine($"Name:{StudentName}");
            Console.WriteLine($"Marks:{Marks}");

        }

    }
}
