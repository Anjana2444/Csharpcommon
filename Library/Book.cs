namespace Library
{
    internal class Book
    {
        public int SerialNo { get; set; }
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public DateTime PublishedAt { get; set; }
        public const string Country = "India";

        public Book()
        {
            PublishedAt = DateTime.Now;
        }
        public Book( int serial_no, string author_name, string title, float price, DateTime publised_at)
        {
            this.SerialNo= serial_no;
            this.Title= title;
            this.AuthorName= author_name;
            this.Price= price;
            this.PublishedAt= publised_at;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Serial No: {this.SerialNo}");
            Console.WriteLine($"Author Name: {this.AuthorName}");
            Console.WriteLine($"Title: {this.Title}");
            Console.WriteLine($"Price: {this.Price}");
            Console.WriteLine($"Published At: {this.PublishedAt}");
        }
        //To get the author name and title
        public string GetAuthorAndTitle()
        {
            string author_and_title=this.AuthorName +" "+this.Title;
            return author_and_title;
        }

        public float SetPriceInDollor(float dollor_value)
        {
            float price_in_rupees = dollor_value * this.Price;
            return price_in_rupees;
        }

    }
}
