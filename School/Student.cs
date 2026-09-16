using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    internal enum Gender { Male, Female, Other }
    internal enum Class { First, Second, Third, Fourth, Fifth, Sixth, Seventh, Eighth, Ninth, Tenth }
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public Gender StudentGender { get; set; }
        public Class StudentClass { get; set; }
        public int StudentAge { get; set; }

        public Student(int studentid, string studentname, Gender studentgender, Class studentclass, int studentage)
        {
            this.StudentId = studentid;
            this.StudentName = studentname;
            this.StudentGender = studentgender;
            this.StudentClass = studentclass;
            this.StudentAge = studentage;

        }

        public static void ShowStudentInfo(Dictionary<int, Student> studentDictionary)
        {
            foreach (var student in studentDictionary.Values)
            {
                Console.WriteLine($"Student ID: {student.StudentId}, Student Name: {student.StudentName}, Gender: {student.StudentGender}, Class: {student.StudentClass}, Age: {student.StudentAge}");
            }
        }

        public static void ShowAddRemoveStudentInfo(Dictionary<int, Student> studentDictionary)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("1. Show All Students");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. Add Student");
                Console.Write("Enter your choice: ");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Please Enter a valid number");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        ShowStudentInfo(studentDictionary);
                        break;

                    case 2:
                        Console.WriteLine("Enter Student ID to remove: ");
                        if (!int.TryParse(Console.ReadLine(), out int idToRemove))
                        {
                            Console.WriteLine("Invalid Student ID!");
                            continue;
                        }
                        if (studentDictionary.ContainsKey(idToRemove))
                        {
                            studentDictionary.Remove(idToRemove);
                            Console.WriteLine("Student removed successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter Student ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Student Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Gender (Male/Female/Other): ");
                        if (!Enum.TryParse<Gender>(Console.ReadLine(),true, out Gender gender))
                        {
                            Console.WriteLine("Invalid Gender.");
                            break;
                        }
                        Console.Write("Enter Class (First/Second/Third/Fourth/Fifth/Sixth/Seventh/Eighth/Ninth/Tenth): ");
                        if(!Enum.TryParse<Class>(Console.ReadLine(),true, out Class className))
                        {
                            Console.WriteLine("Invalid Class.");
                            break;
                        }

                        Console.Write("Enter Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        studentDictionary.Add(id, new Student(id, name, gender, className, age));
                        break;  
                }
            }
        }
    }
}
