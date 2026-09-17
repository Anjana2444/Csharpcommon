
using Students;

StudentDetails s1 = new StudentDetails(1, "Antony Jacob", GenderType.Male, Section.A, Grade.A);
StudentDetails s2 = new StudentDetails(2, "Chris Joseph", GenderType.Female, Section.B, Grade.B);
StudentDetails s3 = new StudentDetails(3, "Adil C P", GenderType.Male, Section.A, Grade.C);
StudentDetails s4 = new StudentDetails(4, "Anjana Rajan", GenderType.Female, Section.C, Grade.A);
StudentDetails s5 = new StudentDetails(5, "Dona Rose Shiju", GenderType.Male, Section.B, Grade.D);
StudentDetails s6 = new StudentDetails(6, "Amal Mathew", GenderType.Female, Section.A, Grade.F);
StudentDetails s7 = new StudentDetails(7, "Allen Philip", GenderType.Male, Section.C, Grade.B);
StudentDetails s8 = new StudentDetails(8, "Jacob Anotny", GenderType.Female, Section.B, Grade.A);
StudentDetails s9 = new StudentDetails(9, "Anns Jacob", GenderType.Male, Section.A, Grade.C);
StudentDetails s10 = new StudentDetails(10, "Allen George", GenderType.Female, Section.C, Grade.D);
Dictionary<int, StudentDetails> StudentBaseDetails = new Dictionary<int, StudentDetails>();
StudentBaseDetails.Add(s1.StudentID, s1);
StudentBaseDetails.Add(s2.StudentID, s2);
StudentBaseDetails.Add(s3.StudentID, s3);
StudentBaseDetails.Add(s4.StudentID, s4);
StudentBaseDetails.Add(s5.StudentID, s5);
StudentBaseDetails.Add(s6.StudentID, s6);
StudentBaseDetails.Add(s7.StudentID, s7);
StudentBaseDetails.Add(s8.StudentID, s8);
StudentBaseDetails.Add(s9.StudentID, s9);
StudentBaseDetails.Add(s10.StudentID, s10);

Console.WriteLine("Id\t| Student Name");
Console.WriteLine("------------------------");
foreach (KeyValuePair<int, StudentDetails> o in StudentBaseDetails)
{
    Console.WriteLine($"{o.Key}\t| {o.Value.Name}");
}

int i = 0;
int student_id;
Section student_section;
Grade student_grade;
GenderType student_gender;

while (true)
{
    Console.WriteLine("================");
    Console.WriteLine("1.Add");
    Console.WriteLine("2.Remove");
    Console.WriteLine("3.Show Details");
    Console.WriteLine("4.Exit");
    Console.WriteLine("================");
    Console.Write("Enter Choice: ");
    i = Convert.ToInt32(Console.ReadLine());
    switch (i)
    {
        case 1:            
            while (true)
            {
                Console.Write("Enter the student id: ");
                student_id = Convert.ToInt32(Console.ReadLine());
                if (StudentBaseDetails.ContainsKey(student_id))
                {
                    Console.WriteLine($"ID {student_id} Exists!!!\n");
                }
                else
                {
                    break;
                }
            }
                
            Console.Write("Enter the student name: ");
            string student_name = Console.ReadLine();
            while (true)
            {
                Console.Write("Enter the student gender (Male, Female): ");
                string student_gender_add = Console.ReadLine();
                if (Enum.TryParse(student_gender_add, true, out student_gender))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid gender!!!");
                }
            }
            while (true)
            {
                Console.Write("Enter the student section (A, B, C): ");
                string student_section_add = Console.ReadLine();
                if (Enum.TryParse(student_section_add, true, out student_section))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid section!!!");
                }
            }
                
            while (true)
            {
                Console.Write("Enter the student grade (A, B, C, D, F): ");
                string student_grade_add = Console.ReadLine();
                if (Enum.TryParse(student_grade_add, true, out student_grade))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Gender!!!");
                }
            }
            StudentDetails newStudent = new StudentDetails(student_id, student_name, student_gender, student_section, student_grade);
            StudentBaseDetails.Add(newStudent.StudentID, newStudent);
            newStudent.PrintStudentGrade();
            break;
        case 2:
            Console.Write("Enter the student id: ");
            int sid = Convert.ToInt32(Console.ReadLine());
            StudentBaseDetails.Remove(sid);
            break;
        case 3:
            foreach (KeyValuePair<int, StudentDetails> o in StudentBaseDetails)
            {
                Console.WriteLine($"ID: {o.Key} Name: {o.Value.Name} Gender: {o.Value.Gender} Section: {o.Value.ClassSection} Grade: {o.Value.StudentGrade}");
            }
            break;
        case 4:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Choice!!!");
            break;
    }
}