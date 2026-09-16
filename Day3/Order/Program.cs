using Order;

DateTime datetime = new DateTime(2026, 09, 15);
Product o1 = new Product(101, "Table", 399, OrderStatus.Shipped, datetime);
//o1.PrintDetails();
//o1.PrintCategory();
//o1.PrintOrderStatus();

Product o2 = new Product(102, "Chair", 200, OrderStatus.Shipped, datetime);
Product o3 = new Product(103, "Bed", 2000, OrderStatus.Shipped, datetime);
Product o4 = new Product(104, "Plate", 270, OrderStatus.Shipped, datetime);
Product o5 = new Product(105, "Mobilephone", 2090, OrderStatus.Shipped, datetime);

//Arrays
//Product[] orders = new[] { o1, o2, o3, o4, o5 };
//for (int i = 0; i < orders.Length; i++)
//{
//    Console.WriteLine(orders[i].Name);
//}


//lists
//List<Product> products = new List<Product>();
//products.Add(o1);
//products.Add(o2);
//products.Add(o3);
//products.Add(o4);
//products.Add(o5);
//foreach (Product p in products)
//{
//     Console.WriteLine(p.Name);
//}


//Dictionary
//Dictionary<int, Product> productsDict = new Dictionary<int, Product>();
//productsDict.Add(1, o1);
//productsDict.Add(2, o2);
//productsDict.Add(3, o3);
//productsDict.Add(4, o4);
//productsDict.Add(5, o5);
//foreach (KeyValuePair<int, Product> p in productsDict)
//{
//    Console.WriteLine($"{p.Key} {p.Value.Name}");
//}
//foreach (int p in productsDict.Keys)
//{
//    Console.WriteLine($"{p}");
//}
//foreach (Product p in productsDict.Values)
//{
//    Console.WriteLine($"{p.Name}");
//}

//for each loop
//foreach (Product o in orders)
//{
//    Console.WriteLine(o.Name);
//}



//loops
//for(int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}

//int i = 11;
//do
//{
//    Console.WriteLine(i);
//    i++;
//}
//while (i < 10);


//Day 4 
Console.WriteLine("Break example");
for (int i = 0; i < 11; i++)
{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine(i);
}

Console.WriteLine("Continue example");
for (int i = 0; i < 11; i++)
{
    if (i == 5)
    {
        continue;
    }
    Console.WriteLine(i);
}

