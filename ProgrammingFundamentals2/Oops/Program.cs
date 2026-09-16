using Oops;
//Console.WriteLine("Vehicle");

//Console.WriteLine("");
//Console.WriteLine("CAR");
//Car c1 = new Car();
//c1.Brand = "Toyota";//inherited property
//c1.Start();
//c1.OpenDoor();
//c1.Display();

//Console.WriteLine("");
//Console.WriteLine("BIKE");
//Bike b1 = new Bike();
//b1.Brand = "Splender"; //inherited property
//b1.Start();
//b1.UseStand();
//b1.Display();

//Console.WriteLine("");
//Console.WriteLine("LORRY");
//Lorry l1 = new Lorry();
//l1.size = "Big";
//l1.Brand = "Bajaj";
//l1.Start();
//l1.EmergencyLight();
//l1.Display();

//Console.WriteLine("");
//Console.WriteLine("VEHICLE - LORRY");
//Vehicle l2 = new Lorry();
////l2.size = "Big";
//l2.Brand = "Bajaj";
//l2.Start();
////l2.EmergencyLight();
//l2.Display();
Console.WriteLine("PERSON");
Console.WriteLine("");
Student s1 = new Student();
s1.HouseNo = 158;
s1.DisplayHouseNo();
s1.Name = "Anjana";
s1.DisplayName();
s1.PlaceOfOrigin();

Console.WriteLine("");

Employee e2 = new Employee();
e2.HouseNo = 151;
e2.DisplayHouseNo();
e2.Name = "Rekha";
e2.DisplayName();
e2.PlaceOfOrigin();

Console.WriteLine("");
Console.WriteLine("DOCUMENTS");
Console.WriteLine("");

Pdf p1 =new Pdf();
p1.FileName = "Ramayanam";
p1.Reusability = "Not Reusable";
p1.DisplayName();
p1.ContentOfTheFile();
p1.LanguageUsedInTheFile();
p1.NumberOfWords();
p1.DisplayStatus();

Console.WriteLine("");

Text t1 = new Text();
t1.FileName = "Mahabharatham";
t1.Reusabilitys = "Reusable";
t1.DisplayName();
t1.ContentOfTheFile();
t1.LanguageUsedInTheFile();
t1.NumberOfWords();
t1.DisplayofStatus();

Console.Read();