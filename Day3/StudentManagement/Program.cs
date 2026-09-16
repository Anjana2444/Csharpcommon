using StudentManagement;

Student s1 = new Student(101,"Chris");
Student s2 = new Student(102, "Antony");
Student s3 = new Student(103, "Adil");
Student s4 = new Student(104,"Dona");
Student s5 = new Student(105, "Anjana");

Dictionary<int, Student> students = new Dictionary<int, Student>();

students.Add(s1.RollNumber,s1);
students.Add(s2.RollNumber, s2);
students.Add(s3.RollNumber, s3);
students.Add(s4.RollNumber, s4);
students.Add(s5.RollNumber, s5);

while (true)
{
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Remove Student");
    Console.WriteLine("3. Show Students");
    Console.WriteLine("4. Exit");

    Console.Write("Enter your choice: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter Roll Number: ");
            int rollNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Student s6= new Student(rollNumber, name);
            students.Add(s6.RollNumber, s6);

            Console.WriteLine("Student added successfully.");
            break;
        case 2:
            Console.Write("Enter Roll Number to remove: ");
            int removeRollNumber = int.Parse(Console.ReadLine());
            if (students.ContainsKey(removeRollNumber))
            {
                students.Remove(removeRollNumber);
                Console.WriteLine("Student removed successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }

            break;
        case 3:
            foreach (KeyValuePair<int, Student> student in students)
            {
                student.Value.PrintDetails();
                Console.WriteLine();
            }

            break;
        case 4:
            return;

    }
}
