using System;
using System.Collections.Generic;
using System.Text;

namespace Order
{
    //enum
    internal enum OrderStatus {OrderPlaced, Dispatched, Shipped, OutForDelivery, Delivered}
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime DateOfOrder { get; set; }

        public Product(int id, string name, int price, OrderStatus status, DateTime dateoforder)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Status = status;
            this.DateOfOrder = dateoforder;
        }
        public void Displaydetais()
        {
            Console.WriteLine($"The ID of Order placed: {this.ID}");
            Console.WriteLine($"The Name of the order placed: {this.Name}");
            Console.WriteLine($"The Price of the order placed: {this.Price}");
            Console.WriteLine($"The status of the order placed: {this.Status}");
            Console.WriteLine($"The time of the order placed: {this.DateOfOrder}");
        }

        public void PrintCategory()
        {
            if (this.Price < 400) 
            {
                Console.WriteLine("Economic Product");
            }
            else if ((400 < this.Price) && (this.Price < 700))
            {
                Console.WriteLine("Mid Range Product");
            }
            else
            {
                Console.WriteLine("Premium Product");
            }


        }

        public void PrintOrderStatus()
        {
            switch(this.Status)
            {
                case OrderStatus.Shipped:
                    Console.WriteLine("Order Shipped");
                    break;

                case OrderStatus.OrderPlaced:
                    Console.WriteLine("Order Placed");
                    break;

                case OrderStatus.Dispatched:
                    Console.WriteLine("Order Dispatched");
                    break;

                case OrderStatus.OutForDelivery:
                    Console.WriteLine("Order Out For Delivery");
                    break;

                case OrderStatus.Delivered:
                    Console.WriteLine("Order Delivered");
                    break;
            }
        }


        

    }
}
