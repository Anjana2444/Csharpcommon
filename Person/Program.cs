using Person;

Father f1 = new Father();
f1.Name = "George Josh";
f1.Designation = "Bank Employee";
f1.Age = 39;
f1.Gender = "Male";
f1.IsBearded = true;
f1.GetIntroduction(f1.Name,f1.Gender,f1.Age,f1.Designation);
f1.Driving(f1.Name);
Console.WriteLine();

Mother m1  = new Mother();
m1.Name = "Anna Maria";
m1.Designation = "Engineer";
m1.Age = 35;
m1.Gender = "Female";
m1.HasShortHair = false;
m1.GetIntroduction(m1.Name, m1.Gender, m1.Age, m1.Designation);
m1.Working(m1.Name);

Console.ReadLine();