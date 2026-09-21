using Printer;

IPrintable p1 = new NormalPrinter();
Console.WriteLine($"The doc type is :{p1.DocumentType}");
p1.Printing();
//Console.WriteLine($"the name of printer:{p1.NameOfPrinter}");
Console.WriteLine();
NormalPrinter p2 = new NormalPrinter();
p2.Printing();
Console.WriteLine($"The doc type is :{p2.DocumentType}");
Console.WriteLine($"The name of the printer is :{p2.NameOfPrinter}");
Console.WriteLine();

AdvancedPrinter a1 = new AdvancedPrinter();
a1.Printing();
a1.Scanner();

MultiFunction m1 = new MultiFunction();
m1.FaxSend();


Console.ReadLine();