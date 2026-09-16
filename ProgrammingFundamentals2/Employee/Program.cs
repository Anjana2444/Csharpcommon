using Employee;
Console.WriteLine("Hello, World!");

Employees employee1 = new Employees {Name = "Megha"};
    employee1.id = 245;

    employee1.team = 'S';

Console.WriteLine("Employee ID: " + employee1.id);
Console.WriteLine("Employee Name: " + employee1.Name);
Console.WriteLine("Included Team: " + employee1.team);

Employees employee2 = new Employees { Name = "Rekha" };
Console.WriteLine("Employee Name: " + employee2.Name);

Console.Read();
