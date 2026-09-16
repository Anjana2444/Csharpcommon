using Oops;

//Car c1 = new Car();
//c1.BrandName = "Toyota";//Inherited Property from Vehicle class
//Console.WriteLine($"Car Brand: {c1.BrandName}");
//c1.start();//Inherited Method from Vehicle class
//c1.OpenDoor();//Method from Car class

//Bike b1 = new Bike();
//b1.BrandName = "Yamaha";//Inherited Property from Vehicle class
//b1.start();//Inherited Method from Vehicle class
//b1.UseStand();//Method from Bike class
//Console.WriteLine($"Bike Brand: {b1.BrandName}");

//Plane p1 = new Plane();
//p1.BrandName = "Boeing";//Inherited Property from Vehicle class
//p1.start();
//p1.TakeOff();
//Console.WriteLine($"Plane Brand: {p1.BrandName}");



//Upi u1 = new Upi();
//u1.UpiId= 1;
//u1.UpiPaymentDone();
//u1.Transaction();
//u1.SendNotification();

//Console.WriteLine();

//CreditCard cc1= new CreditCard();
//cc1.CreditCardId= 1;
//cc1.CreditCardPaymentDone();
//cc1.Transaction();
//cc1.SendNotification();

//Assignment 2

//Pdf p1 = new Pdf();
//p1.PdfName = "pdf1.pdf";
//p1.Read();
//p1.Write();

//Console.WriteLine();

//WordDoc w1 = new WordDoc();
//w1.WordName = "Worddoc1.docx";
//w1.Read();
//w1.Write();

//Console.WriteLine();

//Excel e1 = new Excel();
//e1.ExcelName = "Excel1.xlsx";
//e1.Read();
//e1.Write();

//Assignment 1

Child c1 = new Child();
c1.ChildId = 1;
c1.CitizenId = 101;
c1.IdGeneration();
c1.ChildIdGeneration();
Console.WriteLine($"CitizenId: {c1.CitizenId}");
Console.WriteLine($"Child Id: {c1.ChildId}");

Console.WriteLine();

Student s1 = new Student();
s1.StudentId = 2;
s1.CitizenId = 201;
s1.IdGeneration();
s1.StudentIdGeneration();
Console.WriteLine($"CitizenId: {s1.CitizenId}");
Console.WriteLine($"Student Id: {s1.StudentId}");

Console.WriteLine();

Employee e1 = new Employee();
e1.EmployeeId = 3;
e1.CitizenId = 301;
e1.IdGeneration();
e1.EmployeeIdGeneration();
Console.WriteLine($"CitizenId: {s1.CitizenId}");
Console.WriteLine($"Student Id: {e1.EmployeeId}");




Console.ReadLine();