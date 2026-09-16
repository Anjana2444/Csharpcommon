using System;
using System.Collections.Generic;
using System.Text;

namespace Order
{
    internal enum OrderStatus { OrderPlaced, Dispatched, Shipped, OutForDelivery }
    internal class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public OrderStatus Status { get; set; }

        public DateTime DateOfOrder { get; set; }

        public Product(int id, string name, int price, OrderStatus status, DateTime date_of_order)
        {
            this.ProductId = id;
            this.Name = name;
            this.Price = price;
            this.Status = status;
            this.DateOfOrder = date_of_order;
        }

        public void Display()
        {
            Console.WriteLine($"ProductId:{this.ProductId}");
            Console.WriteLine($"Name:{this.Name}");
            Console.WriteLine($"Price:{this.Price}");
            Console.WriteLine($"Status:{this.Status}");
            Console.WriteLine($"Date_Of_Order:{this.DateOfOrder}");
        }

        public void PrintCategory()
        {
            if (this.Price < 400)
            {
                Console.WriteLine("economic Product");
            }
            else if ((400 < this.Price) && (this.Price < 700))
            {
                Console.WriteLine("Mid Range");
            }
            else
            {
                Console.WriteLine("premimum");
            }



        }

        public void PrintOrderStatus()
        {
            switch(this.Status)
            {
                case OrderStatus.Shipped:
                    Console.WriteLine("Order is Shipped");
                    break;

                case OrderStatus.OrderPlaced:
                    Console.WriteLine("Order is placed");
                    break;
                case OrderStatus.Dispatched:
                    Console.WriteLine(" Order is Dispatched");
                    break;
                default:
                    break;





            }
        }
       


        
    }
}
