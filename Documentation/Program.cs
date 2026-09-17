using Documentation;

Console.WriteLine("PDF");
PDF p1 = new PDF();
p1.DocumentID = 8657;
p1.DocumentName = "OOPS Concept";
Console.WriteLine($"ID: {p1.DocumentID} Title: {p1.DocumentName}");
p1.Options();
p1.NumberOfPages();
Console.WriteLine();

Console.WriteLine("Power Point");
PowerPoint pp1 = new PowerPoint();
pp1.DocumentID = 1234;
pp1.DocumentName = "Frontend Concept";
Console.WriteLine($"ID: {pp1.DocumentID} Title: {pp1.DocumentName}");
pp1.Options();
pp1.NumberOfPages();
Console.WriteLine();

Console.WriteLine("Word Document");
WordDocument wd1 = new WordDocument();
wd1.DocumentID = 6489;
wd1.DocumentName = "API Concept";
Console.WriteLine($"ID: {wd1.DocumentID} Title: {wd1.DocumentName}");
wd1.Options();
wd1.NumberOfPages();
Console.WriteLine();

Console.ReadLine();