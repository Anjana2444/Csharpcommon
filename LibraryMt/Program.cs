
using LibraryMt;

library l1=new library();
l1.Bookname = "C#"; 
l1.AuthorName = "John Doe"; 
l1.Serialno = 12345;  
l1.PublishingDate = new DateTime(2020, 1, 1, 10, 0, 0);

library l2 =new library("Python Programming", 10, 67890, "Jane Smith", new DateTime(2019, 6, 1));


Console.WriteLine($"Book Name: {l1.Bookname}, Author: {l1.AuthorName}, Serial No: {l1.Serialno}, Publishing Date: {l1.PublishingDate}, Country: {library.Country}");

l2.PrintBookDetails();
l1.PrintBookDetails();
string AuthorAndTitle = l2.PrintAuthorAndTitle();
Console.WriteLine("Author and Title 2: " + AuthorAndTitle);
AuthorAndTitle = l1.PrintAuthorAndTitle();
Console.WriteLine("Author and Title 1: " + AuthorAndTitle);
Console.WriteLine("Enter dollar value: ");
string dollar_val= Console.ReadLine();
float dollarval = float.Parse(dollar_val);
float rupee_value = l2.SetPriceinDollar(dollarval);
Console.WriteLine("Rupee Value: " + rupee_value);
Console.ReadLine();