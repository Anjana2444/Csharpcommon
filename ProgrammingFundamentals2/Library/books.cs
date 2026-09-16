namespace Library
{
    internal class books
    {
        public int serialno { get; set; }
        public string AuthorName { get; set; }
        public float price { get; set; }
        public string Title { get; set; }
        public const string Country = "India";
        public DateTime published { get; set; }

        public books()
        {
            published = DateTime.Now;
        }
        public books(int _serialno, string authername, float _price, string title, DateTime _published)
        {
            this.serialno = _serialno;
            this.AuthorName = authername;
            this.price = _price;
            this.Title = title;
            this.published = _published;
        }
        public void display()
        {
            Console.WriteLine($"Serial No: {this.serialno}");
            Console.WriteLine($"Author Name: {this.AuthorName} ");
            Console.WriteLine($"Title: {this.Title}");
            Console.WriteLine($"Price: {this.price} ");
            Console.WriteLine($"Publised At: {this.published}");
        }

        // To get the author name and title

        public string getAuthorandTitle()
        {
            string author_and_title = this.AuthorName+"" + this.Title;
            return this.AuthorName;
        }

        public float SetPriceInDollar(float dollar_value)
        {
            float priceinrupees = dollar_value * this.price;
            return priceinrupees;
        }
    }
}
