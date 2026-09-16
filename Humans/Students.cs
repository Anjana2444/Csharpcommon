using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Humans
{
    internal class Students:Persons
    {
        public  string StuName { get; set; }
        public string SchoolName { get; set; }
        public void GoingToSchool()
        {
            Console.WriteLine($"{StuName} is going to {SchoolName}");
        }
    }
}
