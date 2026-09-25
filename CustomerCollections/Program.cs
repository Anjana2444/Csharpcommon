internal class Employee
{
    public int EmpId { get; set; }
    public string Name { get; set; }
}

internal class Program
{
    static void Main(String[] args)
    {
        Employee employee1 = new Employee { EmpId = 100, Name = "Antony" };
        Employee employee2 = new Employee { EmpId = 101, Name = "Jacob" };

        List<Employee> employees = new List<Employee>();
        employees.Add(employee1);
        employees.Add(employee2);
        Display(employees);
    }
    static void Display(List<Employee> emp)
    {
        foreach (Employee e in emp)
        {
            Console.WriteLine($"Name: {e.Name}, ID: {e.EmpId}");
        }
    }
}