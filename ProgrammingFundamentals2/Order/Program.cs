using Order;
Console.WriteLine("Order");

DateTime datetime = new DateTime(2026, 09, 15);
Product o1 = new Product(1, "Text Book", 499, OrderStatus.Dispatched, datetime);
o1.Displaydetais();
o1.PrintCategory();
o1.PrintOrderStatus();

Product o2 = new Product(2, "Note Book", 199, OrderStatus.Dispatched, datetime);
Product o3 = new Product(3, "Story Book", 799, OrderStatus.Dispatched, datetime);
Product o4 = new Product(4, "Colouring Book", 899, OrderStatus.Dispatched, datetime);
Product o5 = new Product(5, "Excercise Book", 999, OrderStatus.Dispatched, datetime);

//for array
Product[] orders = new[] { o1, o2, o3, o4, o5 };

//for list
List<Product> products = new List<Product>();
products.Add(o1);
products.Add(o2);
products.Add(o3);
products.Add(o4);
products.Add(o5);

//for dictionary
Dictionary<int, Product> orderdictionary = new Dictionary<int, Product>();
orderdictionary.Add(1, o1);
orderdictionary.Add(2, o2);
orderdictionary.Add(3, o3);
orderdictionary.Add(4, o4);
orderdictionary.Add(5, o5);


//for (int i =0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}

//int i = 0;
//while(i < 10)
//{
//    Console.WriteLine(i);
//    i++;
//}

//int i = 0;
//do
//{
//    Console.WriteLine(i);
//    i++;
//}

//while (i < 10);


//for (int i = 0; i < orders.Length; i++)
//{
//    Console.WriteLine($"{orders[i].Name}");
//}

Console.WriteLine("Loop");
 
//for array
foreach (Product a in orders)
{
    Console.WriteLine($"{a.ID}");
}

//for list
products.Remove(o1);

foreach (Product a in products)
{
    Console.WriteLine($"{a.Name}");
}

//for dictionary
foreach (KeyValuePair<int, Product> a in orderdictionary)
{
    Console.WriteLine($"dictionary: {a.Key} {a.Value.Name}");
}

foreach (int a in orderdictionary.Keys)
{
    Console.WriteLine($"dictionary key: {a}");
}

foreach (Product a in orderdictionary.Values)
{
    Console.WriteLine($"dictionary values: {a.Name}");
}

Console.WriteLine("Break at 5");
for (int i =0; i<10; i++)
{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine(i.ToString());
}

Console.WriteLine("Continue at 6");
for (int i = 0; i < 10; i++)
{  
    if (i == 6)
    { continue; }
    Console.WriteLine(i.ToString());
}


Console.Read();

