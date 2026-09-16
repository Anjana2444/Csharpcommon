using Order;
using System.ComponentModel;

Ecommerce e1 = new(1, "Laptop", OrderStatus.Shipped, 1200.00, new DateTime(2023, 10, 1));

//e1.PrintDetails();
//e1.GetCategory();
//e1.CheckStatus();

Ecommerce e2= new(2, "Headphones", OrderStatus.Pending, 150.00, new DateTime(2023, 10, 5));
Ecommerce e3 = new(3, "Smartphone", OrderStatus.Delivered, 800.00, new DateTime(2023, 10, 10));
Ecommerce e4 = new(4, "Monitor", OrderStatus.Shipped, 300.00, new DateTime(2023, 10, 15));
Ecommerce e5 =new(5, "Smartwatch", OrderStatus.Pending, 450.00, new DateTime(2023, 10, 20));

////for Array
//Ecommerce[] orders = new Ecommerce[] { e1, e2, e3, e4, e5 };

////for List
//List< Ecommerce> orderList = new List<Ecommerce>();
//orderList.Add(e1);
//orderList.Add(e2);
//orderList.Add(e3);
//orderList.Add(e4);
//orderList.Add(e5);

////for Dictionary
//Dictionary<int, Ecommerce> orderDictionary = new Dictionary<int, Ecommerce>();
//orderDictionary.Add(e1.OrderId, e1);
//orderDictionary.Add(e2.OrderId, e2);
//orderDictionary.Add(e3.OrderId, e3);
//orderDictionary.Add(e4.OrderId, e4);
//orderDictionary.Add(e5.OrderId, e5);

////foreach (KeyValuePair<int, Ecommerce> pair in orderDictionary)
////{
////    Console.WriteLine($"Order ID: {pair.Key}, Product Name: {pair.Value.ProductName}");
////}

//foreach (Ecommerce order in orderDictionary.Values)
//{
//    Console.WriteLine($"Product Name: {order.ProductName}");
//}


//foreach (Ecommerce order in orderList)
//{
//    Console.WriteLine($"{order.ProductName}");
//}
//orderList.Remove(e1);
//foreach (Ecommerce order in orderList)
//{
//    Console.WriteLine($"{order.ProductName}");
//}
//int i = 0;
//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i < 10);




//Console.WriteLine("Hello, World!");
for (int i = 0; i < 10; i++)
{
    if (i == 5) 
    {
        continue;
    }
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        break; ;
    }
    Console.WriteLine(i);
}

