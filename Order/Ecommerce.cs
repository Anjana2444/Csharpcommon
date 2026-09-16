using System;
using System.Collections.Generic;
using System.Text;

namespace Order
{
    internal enum OrderStatus{Pending, Shipped, Delivered}
    internal class Ecommerce
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public OrderStatus Status { get; set; }
        public double Price { get; set; }
        public DateTime OrderDate { get; set; }


        public Ecommerce(int orderid, string productname, OrderStatus status, double price, DateTime orderdate)
        {
            this.OrderId = orderid;
            this.ProductName = productname;
            this.Status = status;
            this.Price = price;
            this.OrderDate = orderdate;


        }

        public void PrintDetails()
        {
            Console.WriteLine($"Order ID: {this.OrderId}, Product Name: {this.ProductName}, Status: {this.Status}, Price: {this.Price}, Order Date: {this.OrderDate}");
        }

        public void GetCategory() {
            if (this.Price > 1000)
            {
                Console.WriteLine("Premium");
            }
            else if(this.Price>=250 && this.Price<=1000)
            {
                Console.WriteLine("Mid Range");
            }
            else
            {
                Console.WriteLine("Economical");
            }
        }

        public void CheckStatus() 
        {
            switch (this.Status)
            {
                case OrderStatus.Delivered:
                    Console.WriteLine("Order has been delivered.");
                    break;

                case OrderStatus.Pending:
                    Console.WriteLine("Order is Pending. ");
                    break;

                case OrderStatus.Shipped:
                    Console.WriteLine("Order has been Shipped.");
                    break;
            }
        
        }



    }
}
