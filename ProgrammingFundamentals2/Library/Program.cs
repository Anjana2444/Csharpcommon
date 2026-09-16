using Library;
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");

books b1 = new books();
b1.serialno = 101;
b1.AuthorName = "Anjana";
b1.Title = "Fun";
b1.price = 999.99f;
b1.display();
string author_title = b1.getAuthorandTitle();
Console.WriteLine($"Author and Title: {author_title}");
float price_rupees = b1.SetPriceInDollar(98.2f);
Console.WriteLine($"Price in rupees: {price_rupees} ");

// Console.WriteLine("Serial No: " + b1.serialno);
// Console.WriteLine("Author Name: " + b1.AuthorName);
// Console.WriteLine("Title: " + b1.Title);
// Console.WriteLine("Price: " + b1.price);
// Console.WriteLine("Publised At: " + b1.published);
// Console.WriteLine("Country: " + books.Country);
Console.WriteLine("/n");

books b2 = new books(102, "Megha", 999.0f, "Psycho", DateTime.Now);
b2.display();
author_title = b2.getAuthorandTitle();
Console.WriteLine($"Author and Title: {author_title}");
Console.WriteLine("/n");

price_rupees = b2.SetPriceInDollar(98.2f);
Console.WriteLine("Enter the dollar value");
string doll_value = Console.ReadLine();
Console.WriteLine(doll_value);
float dollar = float.Parse(doll_value);
float value2 = Convert.ToSingle(doll_value);
Console.WriteLine(value2);
Console.WriteLine($"Price in rupees: {price_rupees} ");


Console.Read();




