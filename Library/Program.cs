using Library;
Book b1 = new Book();
b1.SerialNo = 101;
b1.AuthorName = "Dona Rose Shiju";
b1.Title = "Bright Sky";
b1.Price = 456;
//b1.PublishedAt = DateTime.Now;
/*Console.WriteLine("SerialNo:" + b1.SerialNo);
Console.WriteLine("AuthorName:" + b1.AuthorName);
Console.WriteLine("Title:" + b1.Title);

Console.WriteLine("Price:" + b1.Price);
Console.WriteLine("PublishedAt" + b1.PublishedAt);
Console.WriteLine("Country:" + Book.Country);*/
b1.Display();
string author_title = b1.GetAuthorandTiltle();
Console.WriteLine($"the author and title:{author_title}");
Console.WriteLine();

Book b2 = new Book(102,"Sara Joseph","Rich Dad Poor Dad",600,DateTime.Now);
b2.setLocation();
b2.Display();
author_title = b2.GetAuthorandTiltle();
Console.WriteLine($"the author and title:{author_title}");
Console.WriteLine("enter the dollar value");
string dollar_value = Console.ReadLine();
float value = float.Parse(dollar_value);

float price_rupees = b2.SetPriceInDollor(value);
Console.WriteLine($"the price in rupees is :{price_rupees}");

Console.ReadLine();





