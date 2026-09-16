
using Humans;
using System.Xml.Linq;

Student s1 = new Student();
s1.Name = "Chris";
s1.Age = 22;
s1.Id = 101;
s1.Course = "Mathematics";
Console.WriteLine("Student Details");
Console.WriteLine($"ID: { s1.Id}");
Console.WriteLine($"Name: {s1.Name}");
Console.WriteLine($"Age: {s1.Age}");
Console.WriteLine($"Course: {s1.Course}");
s1.IsAlive();
s1.IsStudy();

Console.WriteLine();

Employee e1 = new Employee();
e1.Name = "Antony";
e1.Age = 22;
e1.Id = 102;
e1.JobTitle = "SDE";
Console.WriteLine("Employee Details");
Console.WriteLine($"ID: {e1.Id}");
Console.WriteLine($"Name: {e1.Name}");
Console.WriteLine($"Age: {e1.Age}");
Console.WriteLine($"Jobtitle :{e1.JobTitle}");
e1.IsAlive();
e1.IsWorking();

Console.WriteLine();

Retired r1 = new Retired();
r1.Name = "Anjana";
r1.Age = 22;
r1.Id = 103;
r1.Pension = 50000;
Console.WriteLine("Retired Details");
Console.WriteLine($"ID: {r1.Id}");
Console.WriteLine($"Name: {r1.Name}");
Console.WriteLine($"Age: {r1.Age}");
Console.WriteLine($"Pension :{r1.Pension}");
r1.IsAlive();
r1.IsResting();

Console.WriteLine();

Unemployed u1 = new Unemployed();
u1.Name = "Adil";
u1.Age = 22;
u1.Id = 104;
u1.DaysUnemployed = 20;
Console.WriteLine("Unemployed Details");
Console.WriteLine($"ID: {u1.Id}");
Console.WriteLine($"Name: {u1.Name}");
Console.WriteLine($"Age: {u1.Age}");
Console.WriteLine($"Jobtitle :{u1.DaysUnemployed}");
u1.IsAlive();
u1.JobHunt();

Console.ReadLine();

