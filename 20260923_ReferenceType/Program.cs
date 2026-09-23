public class Employee
{
    public int EmpId { get; set; }
    public string Name { get; set; }
}
public class Program
{
    public static void Main(String[] args)
    {
        Employee e1 = new Employee { EmpId = 101, Name = "Antony" };
        EmployeeValueType(e1);
        Console.WriteLine($"Employee ID: {e1.EmpId}, Employee Name: {e1.Name}");
        Employee e2 = new Employee { EmpId = 102, Name = "Jacob" };
        EmployeeReferenceTypeRef(ref e2);
        Console.WriteLine($"Employee ID: {e2.EmpId}, Employee Name: {e2.Name}");
        Employee e3 = new Employee{ };
        EmployeeReferenceTypeOut(out e3);
        Console.WriteLine($"Employee ID: {e3.EmpId}, Employee Name: {e3.Name}");
        Employee e4 = new Employee { EmpId = 104, Name = "Anns" };
        EmployeeReferenceTypeIn(e4);
        Console.WriteLine($"Employee ID: {e4.EmpId}, Employee Name: {e4.Name}");
        Console.ReadLine();
    }
    public static void EmployeeValueType(Employee emp)
    {
        emp = new Employee();
        emp.EmpId = 201;
        emp.Name = "Chris";
    }
    public static void EmployeeReferenceTypeRef(ref Employee emp)
    {
        emp = new Employee();
        emp.EmpId = 202;
        emp.Name = "Joseph";
    }
    public static void EmployeeReferenceTypeOut(out Employee emp)
    {
        emp = new Employee();
        emp.EmpId = 203;
        emp.Name = "George";
    }
    public static void EmployeeReferenceTypeIn(in Employee emp)
    {
        //emp = new Employee();
        emp.EmpId = 204;
        emp.Name = "Adil";
    }
}