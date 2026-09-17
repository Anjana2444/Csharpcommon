using oops;

//Car c1 = new Car();
//c1.Brand = "Toyota";
//Console.WriteLine(c1.Brand);
//c1.Start(); // Inherited function
//c1.OpenDoor();

//Console.WriteLine();

//Bike b1 = new Bike();
//b1.Brand = "Splender"; // Inherited Property
//Console.WriteLine($"Bike: {b1.Brand}");
//b1.Start();
//b1.UseStand();

//Console.WriteLine();

//Lorry l1 = new Lorry();
//l1.Brand = "New";
//Console.WriteLine($"Lorry:{l1.Brand}");
//l1.Start();
//l1.UseBreak();




//Console.WriteLine();

//Upi u1 = new Upi();
//u1.UpiId = 1;
//Console.WriteLine(u1.UpiId);
//u1.UpiPayment();
//u1.Transaction();
//Console.WriteLine();

//DebitCard d1 = new DebitCard();
//d1.CardNumber = 16784322;
//Console.WriteLine($" CardNum:{d1.CardNumber}");
//d1.CardPayment();
//d1.Transaction();

//pdf p1 = new pdf();
//p1.PdfId = 1;
//p1.Title = "42 Square";
//Console.WriteLine($"The title is :{p1.Title}");
//p1.Pages = 45;
//p1.DisplayPageNo();
//p1.Content();
//p1.TimeToRead();

//Console.WriteLine();
//wordDoc w1 = new wordDoc();

//w1.DocId = 1;
//w1.Title = "Rules and Regulation";
//Console.WriteLine($"The title is :{w1.Title}");
//w1.Pages = 100;
//w1.DisplayPageNo();
//w1.Content();
//w1.TimeToRead();

SavingAccount s1 = new SavingAccount();
s1.SetName("Dona", "Rose");
 var bal = s1.CheckBalance();
Console.WriteLine($"{bal}");
s1.Widthdraw(500);
bal = s1.CheckBalance();
Console.WriteLine($"{bal}");

CurrentAccount c1 = new CurrentAccount();
var bal1 = c1.CheckBalance();
Console.WriteLine($"{bal1}");
c1.Widthdraw(500);
bal1 = c1.CheckBalance();
Console.WriteLine($"{bal1}");



Console.ReadLine();
