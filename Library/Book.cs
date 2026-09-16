using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    internal class Book
    {
        public int SerialNo { get; set; }

        public string AuthorName { get; set; }
        public string Title { get; set; }

        public int Price { get; set; }
        public DateTime PublishedAt { get; set; }
        public const string Country = "India";
        public static string Location { get; set; } = "Kerala";

        public Book()
        {
            PublishedAt = DateTime.Now;
        }
        public void setLocation()
        {
            Location = "Tamil Nadu";
        }
        public Book(int serial_no , string author_name,string title,int price,DateTime published_at)
        {
            this.SerialNo = serial_no;
            this.AuthorName = author_name;
            this.Title = title;
            this.Price = price;
            this.PublishedAt = published_at;


        }
        // to display details(no retun val nd para)
        public void Display()
        {
            Console.WriteLine("SerialNo:" + this.SerialNo);
            Console.WriteLine($"AuthorName:{this.AuthorName}");
            Console.WriteLine($"Title:{this.Title}");

            Console.WriteLine($"Price:{this.Price}");
            Console.WriteLine($"PublishedAt {this.PublishedAt}");
            Console.WriteLine($"The region is:{Book.Country}");
            Console.WriteLine($"The region is:{Book.Location}");

        }
        // To get the author name and Tiltle(with return no para)
        public string GetAuthorandTiltle()
        {
            string result = this.AuthorName + "" + this.Title;
            return result;
        }
        // to set price(with return nd para)
        public float SetPriceInDollor(float dollar_value)
        {
            float price_in_rupees = dollar_value * this.Price;
            return price_in_rupees;
        }





    }
}
