using Order;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
DateTime date = new DateTime(2026, 09, 10);


Product p1 = new Product(101, "Book", 400, OrderStatus.Shipped, date);
Product p2 = new Product(102, "Pen", 60, OrderStatus.OutForDelivery, date);
Product p3 = new Product(103, "Paper", 10, OrderStatus.OutForDelivery, date);
Product p4 = new Product(104, "Marker", 20, OrderStatus.OutForDelivery, date);
Product p5 = new Product(105, "Pouch", 70, OrderStatus.OutForDelivery, date);
//Array
Product[] products = new[] { p1, p2, p3, p4, p5 };
p1.Display();
p1.PrintOrderStatus();
//List
List<Product> orders= new List<Product>();
orders.Add(p1);
orders.Add(p2);
orders.Add(p3);
orders.Add(p4);
orders.Add(p5);

// Dictionary
Dictionary<int,Product> orderdict = new Dictionary<int, Product>();
orderdict.Add(01, p1);
orderdict.Add(02, p2);
orderdict.Add(03, p3);
orderdict.Add(04, p4);
orderdict.Add(05, p5);
orderdict.Remove(02);

foreach (KeyValuePair<int,Product> o in orderdict)
{
    Console.WriteLine(o.Value.Name);
    Console.WriteLine(o.Key);
}

for (int i=0; i < 10;i++)
{ 
    if (i == 5)
    {
        continue;
    }
    Console.WriteLine($"Number {i}");
}

for (int j = 0; j<(orders.Count);j++)
{
    if (j == 3)
    {
        break;
    }
    Console.WriteLine($"{j}");
}
 

//foreach (Product a in orderdict.Values)
//{
//    Console.WriteLine($"{a.Name}");
//}











//foreach (Product o in orders)
//{
//    Console.WriteLine(o.Name);
//}

//orders.Remove(p5);







//for (int i = 0; i <= products.Length; i++)
//{
//    Console.WriteLine(products[i]);
//}

//foreach (Product p in products)
//{
//    Console.WriteLine(p.Name);
//}





// Loops
//for(int i=0;i<10;i++)
//{
//    Console.WriteLine($"the numbers are{i}");
//}
//int i = 0;
//while(i<10)
//{
//    Console.WriteLine(i);
//    i++;
//}

////do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i < 10)
Console.ReadLine();



