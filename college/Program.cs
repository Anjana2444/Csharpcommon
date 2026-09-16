using college;
Details d1 = new Details();
Details d2 = new Details();
Details d3 = new Details();
Details d4 = new Details();
Details d5 = new Details();







//Details d2 = new Details(02, "Rose", 98);
//d1.Display();



Dictionary<int, Details> dict = new Dictionary<int, Details>();
int choice;


do
{
  
    Console.WriteLine("==Student Details Adder==");
    Console.WriteLine("\n1.Add Details\n");
    Console.WriteLine("\n2.Remove Details\n");
    Console.WriteLine("\n3.Exit\n");

    Console.WriteLine("Enter the choice you want");
    choice = int.Parse(Console.ReadLine());
   
    switch (choice)
    {
        case 1:

            Console.WriteLine("Enter id");
            d1.StdId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            d1.StudentName = Console.ReadLine();
            Console.WriteLine("Enter marks");
            d1.Marks = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Enter id");
            d2.StdId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            d2.StudentName = Console.ReadLine();
            Console.WriteLine("Enter marks");
            d2.Marks = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Enter id");
            d3.StdId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            d3.StudentName = Console.ReadLine();
            Console.WriteLine("Enter marks");

            Console.WriteLine();

            d4.Marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter id");
            d4.StdId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            d4.StudentName = Console.ReadLine();
            Console.WriteLine("Enter marks");
            d4.Marks = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Enter id");
            d5.StdId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            d5.StudentName = Console.ReadLine();
            Console.WriteLine("Enter marks");
            d5.Marks = int.Parse(Console.ReadLine());


            dict.Add(d1.StdId, d1);
            dict.Add(d2.StdId, d2);
            dict.Add(d3.StdId, d3);
            dict.Add(d4.StdId, d4);
            dict.Add(d5.StdId, d5);


            Console.WriteLine("The items inside the Dict:");
            foreach (KeyValuePair<int, Details> o in dict)
            {
                Console.WriteLine(o.Value.StudentName);
                Console.WriteLine(o.Key);
            }
            break;
        case 2:
            Console.WriteLine("Enter the key to be removed");
            int val = int.Parse(Console.ReadLine());
            dict.Remove(val); 
            Console.WriteLine("The remaining items after removal:");
            //Console.WriteLine($"Total items left in dictionary: {dict.Count}");

            foreach (KeyValuePair<int, Details> a in dict)
            {
                Console.WriteLine(a.Value.StudentName);
                Console.WriteLine(a.Key);
            }
            break;
        case 3:
            Console.WriteLine("exit");
            break;
    }
} while(choice != 3);




