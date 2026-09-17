using Order;

Console.WriteLine("---Full Order Details---");
DateOnly date_1 = new DateOnly(2026, 09, 10);

Product product_1 = new Product(100, "Keyboard", 299, OrderStatus.OrderPlace, date_1);
Product product_2 = new Product(101, "Mouse", 599, OrderStatus.OrderPlace, date_1);
Product product_3 = new Product(102, "Laptop", 600000, OrderStatus.OrderPlace, date_1);
Product product_4 = new Product(103, "Speaker", 1200, OrderStatus.OrderPlace, date_1);
Product product_5 = new Product(104, "Headphones", 8000, OrderStatus.OrderPlace, date_1);

//Array
Product[] Orders = new[] {product_1, product_2, product_3, product_4, product_5};

//for  (int i = 0; i < Orders.Length; i++)
//{
//    Console.WriteLine($"Id: {Orders[i].ID}\nName: {Orders[i].Name}\nPrice: {Orders[i].Price}\nStatus: {Orders[i].Status}\nDate of Order: {Orders[i].OrderDate}\n\n");
//}

//foreach (Product o in Orders)
//{
//    Console.WriteLine($"Id: {o.ID}\nName: {o.Name}\nPrice: {o.Price}\nStatus: {o.Status}\nDate of Order: {o.OrderDate}\n\n");
//}

//List
List<Product> Products = new List<Product>();
Products.Add(product_1);
Products.Add(product_2);
Products.Add(product_3);
Products.Add(product_4);
Products.Add(product_5);
//foreach(Product o in Products)
//{
//    Console.WriteLine($"Id: {o.ID}\nName: {o.Name}\nPrice: {o.Price}\nStatus: {o.Status}\nDate of Order: {o.OrderDate}\n\n");
//}

//Dictionary
Dictionary<int, Product> Items = new Dictionary<int, Product>();
Items.Add(product_1.ID, product_1);
Items.Add(product_2.ID, product_2);
Items.Add(product_3.ID, product_3);
Items.Add(product_4.ID, product_4);
Items.Add(product_5.ID, product_5);
foreach (KeyValuePair<int, Product> o in Items)
{
    Console.WriteLine($"Id: {o.Key} Product: {o.Value.Name}");
}
foreach (int o in Items.Keys)
{
    Console.WriteLine($"Id: {o}");
}
foreach (Product o in Items.Values)
{
    Console.WriteLine($"Product Name: {o.Name}");
}

Console.ReadLine();