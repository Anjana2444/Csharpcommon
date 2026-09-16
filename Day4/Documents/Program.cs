using AllDocuments;

Pdf p1= new Pdf();
p1.FileName = "Hello.pdf";
Console.WriteLine($"Name: {p1.FileName}");
p1.OpenDocument();

Console.WriteLine();

Ppt t1 = new Ppt();
t1.FileName = "Hello.ppt";
Console.WriteLine($"Name: {t1.FileName}");
t1.OpenDocument();

Console.WriteLine();

Doc d1 = new Doc();
d1.FileName = "Hello.doc";
Console.WriteLine($"Name: {d1.FileName}");
d1.OpenDocument();

Console.ReadLine();