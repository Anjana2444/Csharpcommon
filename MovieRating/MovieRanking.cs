using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRating

{
    internal enum MovieRatings { Excellent, Average, Bad, Poor }
    internal class MovieRanking
    {
        public int MovieId { get; set; }

        public string MovieName { get; set; }

        public int Price { get; set; }

        public MovieRatings Ratings { get; set; }
    


     public MovieRanking(int id, string name,int price,MovieRatings rating)
        {
            this.MovieId = id;
            this.MovieName = name;
            this.Price = price;
            this.Ratings = rating;
        }
    public void DiplayDetails()
        {
            Console.WriteLine($"Movie Id:{MovieId}");
            Console.WriteLine($"Movie Name:{MovieName}");
            Console.WriteLine($"Price:{Price}");
            Console.WriteLine($"Ratings:{Ratings}");


        }
    public void DisplayRating()
        {
            switch(this.Ratings)
            {
                case MovieRatings.Excellent:
                    Console.WriteLine($"Excellent Movie.Must Watch!");
                    break;
                case MovieRatings.Average:
                    Console.WriteLine($"Not Bad.One Time Watch");
                    break;
                case MovieRatings.Bad:
                    Console.WriteLine($"Bad");
                    break;
                case MovieRatings.Poor:
                    Console.WriteLine($"Not Recommended");
                    break;


            }
        }

    }
}

