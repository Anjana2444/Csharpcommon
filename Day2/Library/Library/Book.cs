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
        public DateTime PublisedAt { get; set; }
        public const string Country = "India";

        public Book()
        {
            PublisedAt = DateTime.Now;
        }
        public Book(int serial_no, string author_name, string title, int price, DateTime published_at)
        {
            this.SerialNo = serial_no;
            this.Title = title;
            this.AuthorName = author_name;
            this.Price = price;
            this.PublisedAt = published_at;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"SerialNo:  {this.SerialNo}");
            Console.WriteLine($"Auhtor Name: {this.AuthorName}");
            Console.WriteLine($"Title: {this.Title}");
            Console.WriteLine($"Price:  {this.Price}");
            Console.WriteLine($"Published At:  {this.PublisedAt}");

        }
        //to get author name and title
        public string GetAuthorAndTitle() 
        {
            string author_and_title = this.AuthorName + ": " + this.Title;
            return author_and_title;
        }

        public float SetPriceInDollar(float dollar_value) 
        {
            float rupees = dollar_value * this.Price;
            return rupees;
        }
    }
}                 