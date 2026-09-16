using Oops;

Car c1 = new Car();
c1.Brand = "Toyota"; //inherited property
Console.WriteLine($"Car : {c1.Brand}");
c1.Start(); //inherited method
c1.OpenDoor();

Console.WriteLine();

Bike b1 = new Bike();
b1.Brand = "Honda"; //inherited property
Console.WriteLine($"Bike : {b1.Brand}");
b1.Start(); //Inherited method
b1.UseStand();

Console.WriteLine();

Lorry l1=new Lorry();
l1.Brand = "Ashok Leyland";
Console.WriteLine($"Lorry : {l1.Brand}");
l1.Start();
l1.UseBreak();

Console.ReadLine();