using School;
Student s1=new Student(1, "John Doe", Gender.Male,Class.Sixth, 12);
Student s2 = new Student(2, "Jane Smith", Gender.Female, Class.Seventh, 13);
Student s3 = new Student(3, "Alex Johnson", Gender.Other, Class.Eighth, 14);
Student s4 = new Student(4, "Emily Brown", Gender.Female, Class.Fourth, 10);
Student s5 = new Student(5, "Michael Davis", Gender.Male, Class.Tenth, 15);
Student s6 = new Student(6, "Sarah Wilson", Gender.Male, Class.Fifth, 11);
Student s7 = new Student(7, "David Lee", Gender.Male, Class.Ninth, 14);
Student s8 = new Student(8, "Olivia Taylor", Gender.Other, Class.Second, 8);
Student s9 = new Student(9, "Daniel Anderson", Gender.Male, Class.Eighth, 13);
Student s10 = new Student(10, "Sophia Martinez", Gender.Female, Class.Eighth, 14);

Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();

studentDictionary.Add(s1.StudentId, s1);
studentDictionary.Add(s2.StudentId, s2);
studentDictionary.Add(s3.StudentId, s3);
studentDictionary.Add(s4.StudentId, s4);
studentDictionary.Add(s5.StudentId, s5);
studentDictionary.Add(s6.StudentId, s6);
studentDictionary.Add(s7.StudentId, s7);
studentDictionary.Add(s8.StudentId, s8);
studentDictionary.Add(s9.StudentId, s9);
studentDictionary.Add(s10.StudentId, s10);

Student.ShowAddRemoveStudentInfo(studentDictionary);

//Console.WriteLine("Hello, World!");
