using Printer;

Console.WriteLine("Normal Printer");
NormalPrinter normalPrinter = new NormalPrinter();
Console.Write("Enter the Document Type: ");
normalPrinter.DocumentType = Console.ReadLine();
Console.Write("Enter Number of pages: ");
normalPrinter.NumberOfPages = Convert.ToInt32(Console.ReadLine());
normalPrinter.Printable();
normalPrinter.Scanable();
Console.WriteLine();

Console.WriteLine("Advance Printer");
AdvancePrinter advancePrinter = new AdvancePrinter();
Console.Write("Enter the Document Type: ");
advancePrinter.DocumentType = Console.ReadLine();
Console.Write("Enter Number of pages: ");
advancePrinter.NumberOfPages = Convert.ToInt32(Console.ReadLine());
advancePrinter.Printable();
advancePrinter.Scanable();
Console.WriteLine();

Console.WriteLine("MultiFunction Printer");
MultifunctionPrinter multifunctionPrinter = new MultifunctionPrinter();
Console.Write("Enter the Document Type: ");
multifunctionPrinter.DocumentType = Console.ReadLine();
Console.Write("Enter Number of pages: ");
multifunctionPrinter.NumberOfPages = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Machine Number: ");
multifunctionPrinter.MachineNumber = Convert.ToInt32(Console.ReadLine());
multifunctionPrinter.Printable();
multifunctionPrinter.Scanable();
multifunctionPrinter.Faxable();

Console.ReadLine();