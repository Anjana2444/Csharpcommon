using System;
using System.Collections.Generic;
using System.Text;

namespace Order
{
    internal enum OrderStatus {OrderPlaced, Dispatched, Shipped, OutForDelivery}
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public OrderStatus Status{ get; set; }
        public DateTime DateOfOrder { get; set; }

        public Product(int id, string name, int price, OrderStatus status,DateTime dateoforder)
        {
            this.Id=id;
            this.Name=name;
            this.Price=price;
            this.Status=status;
            this.DateOfOrder=dateoforder;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Order ID : {this.Id }");
            Console.WriteLine($"Name : {this.Name}");
            Console.WriteLine($"Price : {this.Price}");
            Console.WriteLine($"Status : {this.Status}");
            Console.WriteLine($"Ordered at : {this.DateOfOrder}");
        }

        public void PrintCategory()
        {
            if (this.Price > 500)
            {
                Console.WriteLine("Premium Product");
            }
            else if (this.Price>=100 && this.Price<=500)
            {
                Console.WriteLine("Mid range");
            }
            else
            {
                Console.WriteLine("Second quality");
            }
        }

        public void PrintOrderStatus()
        {
            switch (this.Status)
            {
                case OrderStatus.OrderPlaced:
                    Console.WriteLine("The order has been placed");
                    break;
                case OrderStatus.Dispatched:
                    Console.WriteLine("The product has been displatched");
                    break;
                case OrderStatus.Shipped:
                    Console.WriteLine("The product has been shipped");
                    break;
                case OrderStatus.OutForDelivery:
                    Console.WriteLine("Out For Delivery");
                    break;

            }
        }
    }
}
