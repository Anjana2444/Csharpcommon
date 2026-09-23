internal class Program
{
    static bool availability = false;
    static int pen_availability = 32, bag_availability = 58, book_availability=0, quantity;
    static float discount_price;
    static string email="", sms="", name="", product_name="";
    static async Task Main(String[] args)
    {
        while (true)
        {
            email = "";
            sms = "";
            name = "";
            product_name = "";
            Console.WriteLine("Shopping!!!");
            Console.WriteLine($"1. Pen (Rs.5)\t\tItems Available: {pen_availability}");
            Console.WriteLine($"2. Book (Rs.100)\tItems Available: {book_availability}");
            Console.WriteLine($"3. Bag (Rs.600)\t\tItems Available: {bag_availability}");
            Console.WriteLine("4. Exit");
            Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Quantity: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    product_name = "Pen";
                    Task task_product1 = (Product(2000, "Pen", 1));
                    Task task_inventory1 = (Inventory(3000, quantity, 1));
                    Task task_offer1 = (Offer(4000, 5, 30, 1));
                    await Task.WhenAll(task_product1, task_inventory1, task_offer1);
                    break;
                case 2:
                    Console.Write("Enter Quantity: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    product_name = "Book";
                    Task task_product2 = (Product(2000, "Book", 2));
                    Task task_inventory2 = (Inventory(3000, quantity, 2));
                    Task task_offer2 = (Offer(4000, 100, 10, 2));
                    await Task.WhenAll(task_product2, task_inventory2, task_offer2);
                    break;
                case 3:
                    Console.Write("Enter Quantity: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    product_name = "Bag";
                    Task task_product3 = (Product(2000, "Bag", 3));
                    Task task_inventory3 = (Inventory(3000, quantity, 3));
                    Task task_offer3 = (Offer(4000, 600, 20, 3));
                    await Task.WhenAll(task_product3, task_inventory3, task_offer3);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Choice!!!\n");
                    availability = false;
                    break;
            }
            if (availability)
            {
                while(email == "" || name == "" || sms == "")
                {
                    Console.WriteLine("\nPayment Page");
                    Console.Write("Enter Name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter Email ID: ");
                    email = Console.ReadLine();
                    Console.Write("Enter Phone Number: ");
                    sms = Console.ReadLine();
                }
                await (Payment());
            }
        }
    }
    static async Task Product(int delay, string name, int product_id)
    {
        await Task.Delay(delay);
        Console.WriteLine($"Product Details:\nProduct ID: {product_id}\tProduct Name: {name}");
    }
    static async Task Inventory(int delay, int quantity, int product_id)
    {
        await Task.Delay(delay);
        if (product_id == 1)
        {
            Console.WriteLine($"Pen quantity available in inventory: {pen_availability}");
            if (quantity <= pen_availability && quantity != 0)
            {
                availability = true;
                pen_availability = pen_availability - quantity;
                Console.WriteLine($"Pen available in inventory after purchase: {pen_availability}");
            }
            else
            {
                availability = false;
                Console.WriteLine($"That much quanitiy not available!!!\nPen Quantity: {pen_availability}\n");
            }
        }
        else if (product_id == 2)
        {
            Console.WriteLine($"Book quantity available in inventory: {book_availability}");
            if (quantity <= book_availability && quantity!=0)
            {
                availability = true;
                book_availability = book_availability - quantity;
                Console.WriteLine($"Book available in inventory after purchase: {book_availability}");
            }
            else
            {
                availability = false;
                Console.WriteLine($"That much quanitiy not available!!!\nBook Quantity: {book_availability}\n");
            }
        }
        else
        {
            Console.WriteLine($"Bag quantity available in inventory: {bag_availability}");
            if (quantity <= bag_availability && quantity != 0)
            {
                availability = true;
                bag_availability = bag_availability - quantity;
                Console.WriteLine($"Bag available in inventory after purchase: {bag_availability}");
            }
            else
            {
                availability = false;
                Console.WriteLine($"That much quanitiy not available!!!\nBag Quantity: {bag_availability}\n");
            }
        }
    }
    static async Task Offer(int delay, float price, float discount, int product_id)
    {
        await Task.Delay(delay);
        if (availability)
        {
            Console.WriteLine($"Discount: {discount}%");
            discount_price = (price * discount) / 100;
            Console.WriteLine($"Final Price: {discount_price}");
        }
    }
    static async Task Payment()
    {
        Task vendor_a = (Vendor(3000, "A"));
        Task vendor_b = (Vendor(3000, "B"));
        Task vendor_c = (Vendor(3000, "C"));
        Task<string> vendor = (Task<string>)await Task.WhenAny(vendor_a, vendor_b, vendor_c);
        string winner_vendor = await vendor;
        if (vendor == vendor_a)
        {
            Console.WriteLine(winner_vendor);
            Console.WriteLine("Vendor B: Not Available\nVendor C: Not Available");
        }
        else if (vendor == vendor_b)
        {
            Console.WriteLine(winner_vendor);
            Console.WriteLine("Vendor A: Not Available\nVendor C: Not Available");
        }
        else if (vendor == vendor_c)
        {
            Console.WriteLine(winner_vendor);
            Console.WriteLine("Vendor A: Not Available\nVendor B: Not Available");
        }
        await Task.WhenAll(Email(2000), SMS(4000));
        Console.WriteLine("\nPurchasing Completed!!!");
    }
    static async Task<string> Vendor(int delay, string name)
    {
        await Task.Delay(delay);
        return $"\nVendor is: {name}";
    }
    static async Task Email(int delay)
    {
        await Task.Delay(delay);
        Console.WriteLine($"\nEMAIL\nEmail ID: {email}\nSubject: Purchase Successful\nDear {name},\nPurchase of {product_name} of quantity {quantity} has been successful.\nThank You");
    }
    static async Task SMS(int delay)
    {
        await Task.Delay(delay);
        Console.WriteLine($"\nSMS\nPhone No.: {sms}\nSubject: Purchase Successful\nDear {name},\nPurchase of {product_name} of quantity {quantity} has been successful.\nThank You");
    }
}