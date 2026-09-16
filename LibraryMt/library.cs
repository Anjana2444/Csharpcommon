using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace LibraryMt
{
    internal class library
    {
        public string Bookname { get; set; }
        public int Serialno { get; set; }
        public string AuthorName { get; set; }
        public DateTime PublishingDate { get; set; }
        public const string Country = "India";

        public float price { get; set; } = 0f;


        public library()
        {
            PublishingDate = new DateTime(2020, 1, 1, 10, 0, 0);
        }

        public library(string Book_name, int _price, int Serial_No, string Author_Name, DateTime Publishing_Date) {
            this.Bookname = Book_name;
            this.Serialno = Serial_No;
            this.AuthorName= Author_Name;
            this.PublishingDate = Publishing_Date;
            this.price = _price;    

        }
        public void PrintBookDetails()
        {
            Console.WriteLine($"Book Name: {this.Bookname}, Author: {this.AuthorName}, Serial No: {this.Serialno}, Publishing Date: {this.PublishingDate}, Country: {Country}");
        }

        public string PrintAuthorAndTitle() {
            string AuthorAndTitle = this.AuthorName + " - " + this.Bookname;
            return AuthorAndTitle;
        }

        public float SetPriceinDollar(float dollar_value) {
            float rupee_value = dollar_value * price;
            return rupee_value;
        }
    }
}
