using Demo;

Console.WriteLine("Hello, World!");
Employee e1 = new Employee("dona",001,100000);
Console.WriteLine("The details of the employee:\n" + "Name:"+e1.name +"\n"+"id:"+e1.id+"\n"+"salary:"+e1.salary);
e1.show();

Console.ReadLine();

