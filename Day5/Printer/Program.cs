using Printer;

NormalPrinter n1 = new NormalPrinter();
n1.Print();

Console.WriteLine();

MultiFunctionPrinter m1 = new MultiFunctionPrinter();
m1.Print();
m1.Scan();
m1.Fax();

Console.WriteLine();

AdvancedPrinter a1 = new AdvancedPrinter();
a1.Print();
a1.Scan();
a1.Fax();
a1.PrintInColor();

Console.ReadLine();