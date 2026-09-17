using System;
using System.Collections.Generic;
using System.Text;

namespace Order
{
    internal enum OrderStatus {OrderPlace, Dispatched, Delivered, Shipped, OutForDelivery}
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public OrderStatus Status { get; set; }
        public DateOnly OrderDate { get; set; }

        public Product(int id, string name, int price, OrderStatus status, DateOnly order_date)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Status = status;
            this.OrderDate = order_date;
        }
        public void PrintOrderDetails()
        {
            Console.WriteLine($"Id: {this.ID}\nName: {this.Name}\nPrice: {this.Price}\nStatus: {this.Status}\nDate of Order: {this.OrderDate}");
        }

        public void PrintCategory()
        {
            if (this.Price>500)
            {
                Console.WriteLine("Premium Product!!!");
            }
            else if(this.Price>200 && this.Price<500)
            {
                Console.WriteLine("Mid-Range Product!!!");
            }
            else
            {
                Console.WriteLine("Economy Product!!!");
            }
        }
        public void PrintOrderStatus()
        {
            switch(this.Status)
            {
                case OrderStatus.OrderPlace:
                    Console.WriteLine("The order has been placed successfully!");
                    break;
                case OrderStatus.Delivered:
                    Console.WriteLine("The order is delivered!");
                    break;
                case OrderStatus.OutForDelivery:
                    Console.WriteLine("The order is out for delivery!");
                    break;
                case OrderStatus.Dispatched:
                    Console.WriteLine("The order is dispatched from here!");
                    break;
                case OrderStatus.Shipped:
                    Console.WriteLine("The order is shipped for delivery!");
                    break;
            }
        }
    }
}
