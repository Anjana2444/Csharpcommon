using Vehicle;

Car c1 = new Car();
c1.Brand = "Lamorgini";
Console.WriteLine($"Car: {c1.Brand}");
c1.Start();
c1.OpenDoor();

Bike b1 = new Bike();
b1.Brand = "Duke"; //Inherited Property
Console.WriteLine($"Bike: {b1.Brand}");
b1.Start(); //Inherited Method
b1.UseStand();

Lorry l1 = new Lorry();
l1.Brand = "Bharat Benz";
Console.WriteLine($"Lorry: {l1.Brand}");
l1.Start();
l1.LoadDetails();

Console.ReadLine();