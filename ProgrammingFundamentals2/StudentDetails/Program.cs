using Student;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;
Console.WriteLine("Details of the Students in the school");

DateTime datetime = new DateTime(2026, 09, 15);


Dictionary<int, Details> studentdictionary = new Dictionary<int, Details>();

// A constant in dictionary
Details d13 = new Details(119, 11, Details.School, datetime);


Details d1 = new Details(119, 11, "Anjana", datetime);
Details d2 = new Details(120, 12, "Ammu", datetime);
Details d3 = new Details(121, 13, "Anu", datetime);
Details d4 = new Details(122, 14, "Anju", datetime);
Details d5 = new Details(123, 15, "Manju", datetime);
Details d6 = new Details(124, 16, "Sharu", datetime);
Details d7 = new Details(125, 17, "Devy", datetime);
Details d8 = new Details(126, 18, "Manu", datetime);
Details d9 = new Details(127, 19, "Madhu", datetime);
Details d10 = new Details(128, 20, "Rakhi", datetime);
Details d11 = new Details(129, 21, "Ann", datetime);
Details d12 = new Details(130, 22, "Ramu", datetime);
studentdictionary.Add(1, d1);
studentdictionary.Add(2, d2);
studentdictionary.Add(3, d3);
studentdictionary.Add(4, d5);
studentdictionary.Add(6, d6);
studentdictionary.Add(5, d5);
studentdictionary.Add(7, d7);
studentdictionary.Add(8, d8);
studentdictionary.Add(9, d9);
studentdictionary.Add(10, d10);

//d1.DisplayDetails();
//Console.WriteLine("");
//d2.DisplayDetails();
//Console.WriteLine("");
//d3.DisplayDetails();
//Console.WriteLine("");
//d4.DisplayDetails();
//Console.WriteLine("");
//d5.DisplayDetails();
//Console.WriteLine("");
//d6.DisplayDetails();
//Console.WriteLine("");
//d7.DisplayDetails();
//Console.WriteLine("");
//d9.DisplayDetails();
//Console.WriteLine("");
//d10.DisplayDetails();

foreach (KeyValuePair<int, Details> a in studentdictionary)
{
    Console.WriteLine($"Student Name: {a.Key} {a.Value.Name}");
    Console.WriteLine($"Student Admiss no: {a.Key} {a.Value.Admissno}");
    Console.WriteLine($"Student Roll no: {a.Key} {a.Value.Rollno}");
    Console.WriteLine($"Student Date of Admission: {a.Key} {a.Value.DateOfAdmiss}");
    //Console.WriteLine($"Student Date of Admission: {a.Key} {a.Value.School}");
}

Console.WriteLine("");

Console.WriteLine("Choose the action: a. Add new student  b. Remove a student");
string option = Console.ReadLine();
if (option == "a")
{
    //Console.WriteLine("How many students to be added?");
    //string number = Console.ReadLine();
    //int num = int.Parse(number);

    Console.WriteLine("Ann/Ramu?");
    string number = Console.ReadLine();
    if (number == "Ann")
    {
        studentdictionary.Add(11, d11);
    }
    else if (number == "Ramu")
    {
        studentdictionary.Add(12, d12);
    }
    else
    {
        Console.WriteLine("Not a valid activity");
    }
}
else
{
    Console.Write("Enter the Student ID to remove: ");
    string id = Console.ReadLine();
    int _id = int.Parse(id);
    studentdictionary.Remove(_id);
    Console.WriteLine("Student removed successfully!");


    //string number = Console.ReadLine();
    //if (number == "Anju")
    //{
    //    studentdictionary.Remove(4);
    //}
    //else if (number == "Ammu")
    //{
    //    studentdictionary.Remove(2);
    //}
    //else
    //{
    //    studentdictionary.Remove(2);
    //}
}

foreach (KeyValuePair<int, Details> a in studentdictionary)
{
    Console.WriteLine($"Student Name: {a.Key} {a.Value.Name}");
    Console.WriteLine($"Student Admiss no: {a.Key} {a.Value.Admissno}");
    Console.WriteLine($"Student Roll no: {a.Key} {a.Value.Rollno}");
    Console.WriteLine($"Student Date of Admission: {a.Key} {a.Value.DateOfAdmiss}");
}