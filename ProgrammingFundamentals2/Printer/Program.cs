using Printer;

Console.WriteLine("Printers");


Console.WriteLine(" ");
Console.WriteLine("Normal Printer");
NormalPrinter n1 = new NormalPrinter();
n1.Print();
n1.Speed = 1000;
Console.WriteLine($"{n1.Speed}");

Console.WriteLine(" ");
Console.WriteLine("Advanced Printer");
AdvancedPrinter a1 = new AdvancedPrinter();
a1.Print();
a1.Scan();
a1.Level = 2;
a1.Speed = 2000;
Console.WriteLine($"{a1.Level}");
Console.WriteLine($"{a1.Speed}");

Console.WriteLine(" ");
Console.WriteLine("Multifunctional Printer");
MultifunctionalPrinter m1 = new MultifunctionalPrinter();
m1.Print();
m1.Scan();
m1.Fax();
m1.Speed = 2000;
Console.WriteLine($"{m1.Speed}");