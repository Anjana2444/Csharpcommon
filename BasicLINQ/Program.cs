internal class Employee
{
    public int EmpId { get; set; }
    public int Salary { get; set; }
    public string Name { get; set; }
}

internal class Program
{
    static void Main(String[] args)
    {
        Employee employee1 = new Employee { EmpId = 100, Name = "Antony", Salary = 50000 };
        Employee employee2 = new Employee { EmpId = 101, Name = "Jacob", Salary = 30000 };
        List<Employee> employees = [];
        employees.Add(employee1);
        employees.Add(employee2);
        var details = employees
            .Where(x => x.Salary > 35000)
            .Select(x => new { x.EmpId, x.Name })
            .ToList();
        foreach (var employee in details)
        {
            Console.WriteLine(employee);
        }
    }
}