using Humans;

Students s1 = new Students();
Console.WriteLine($"no of legs for a student:{Persons.NoOfLegs}");
s1.StuName = "dona";
s1.SchoolName = "ABC public school";
s1.GoingToSchool();
s1.Breathing();

Console.WriteLine();
Employee e1 = new Employee();
Console.WriteLine($"no of legs for an employee:{Persons.NoOfLegs}");
e1.EmpName = "Dona Rose";
e1.CompanyName = "42 Square";
e1.GoingToOffice();
e1.Breathing();
