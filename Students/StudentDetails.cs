using System;
using System.Collections.Generic;
using System.Text;

namespace Students {
    internal enum Section { A, B, C }
    internal enum Grade { A, B, C, D, F }
    internal enum GenderType { Male, Female }
    internal class StudentDetails
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public GenderType Gender { get; set; }
        public Section ClassSection { get; set; }
        public Grade StudentGrade { get; set; }
        public StudentDetails(int id, string name, GenderType gender, Section class_section, Grade grade)
        {
            this.StudentID = id;
            this.Name = name;
            this.Gender = gender;
            this.ClassSection = class_section;
            this.StudentGrade = grade;
        }
        public void PrintStudentGrade()
        {
            switch (this.StudentGrade)
            {
                case Grade.A:
                    Console.WriteLine("Congratulations");
                    break;
                case Grade.B:
                    Console.WriteLine("Keep it up");
                    break;
                case Grade.C:
                    Console.WriteLine("Can improve more");
                    break;
                case Grade.D:
                    Console.WriteLine("Do better");
                    break;
                case Grade.F:
                    Console.WriteLine("Failed!!!");
                    break;
            }
        }
    }
}
