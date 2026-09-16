using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    internal class Details
    {
        public int Admissno { get; set; }
        public int Rollno { get; set; }
        public string Name { get; set; }
        public const string School = "Georgian English Medium High School";
        public DateTime DateOfAdmiss { get; set; }

        public Details(int admissno, int rollno, string name, DateTime dateofadmiss)
        {
            this.Rollno = rollno;
            this.Admissno = admissno;
            this.Name = name;
            this.DateOfAdmiss = dateofadmiss;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Admission Number: {this.Admissno}");
            Console.WriteLine($"Roll Number     : {this.Rollno}");
            Console.WriteLine($"Name            : {this.Name}");
            Console.WriteLine($"School name     : {School}");
            Console.WriteLine($"Admission date  : {this.DateOfAdmiss}");
        }
    }
}
