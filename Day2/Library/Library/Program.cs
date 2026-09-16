using Library;

Book b1 = new Book();
b1.SerialNo = 101;
b1.AuthorName = "Chris";
b1.Title = "Life of pie";
b1.Price = 100;
b1.PublisedAt = DateTime.Now;

//Console.WriteLine("SerialNo: " + b1.SerialNo);
//Console.WriteLine("Auhtor Name: " + b1.AuthorName);
//Console.WriteLine("Title: " + b1.Title);
//Console.WriteLine("Published At: " + b1.PublisedAt);
//Console.WriteLine("Country: " + Book.Country);
b1.PrintDetails();
string author_title = b1.GetAuthorAndTitle();
Console.WriteLine($"Author and Title :- {author_title}");

Console.WriteLine("Enter the value of dollar in rupees");
float dollar_value = float.Parse(Console.ReadLine());
float rupees = b1.SetPriceInDollar(dollar_value);
Console.WriteLine($"Price in Rupees: {rupees}");
Console.WriteLine();

Book b2 = new Book(102,"Antony","Never lie",1000,DateTime.Now);

b2.PrintDetails();
author_title=b2.GetAuthorAndTitle();
Console.WriteLine($"Author and Title :- {author_title}");

Console.WriteLine("Enter the value of dollar in rupees");
dollar_value= float.Parse(Console.ReadLine());
rupees = b2.SetPriceInDollar(dollar_value);
Console.WriteLine($"Price in Rupees: {rupees}");

Console.ReadLine();
