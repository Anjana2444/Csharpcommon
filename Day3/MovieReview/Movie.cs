using System;
using System.Collections.Generic;
using System.Text;

namespace MovieReview
{
    internal enum Rating { OneStar, TwoStar ,ThreeStar,FourStar, FiveStar}
    internal enum Genre { Action,Comedy,Drama,Thriller,Horror}
    internal enum Review { VeryPoor,BelowAverage,Average, Good,Excellant}
    internal class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Rating  MovieRating { get; set; }
        public Genre MovieGenre { get; set; }

        public Movie(int id, string name, Rating movieRating, Genre movieGenre)
        {
            this.Id= id;
            this.Name= name;
            this.MovieRating= movieRating;
            this.MovieGenre= movieGenre;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Movie ID : {this.Id}");
            Console.WriteLine($"Movie Name : {this.Name}");
            Console.WriteLine($"Genre : {this.MovieGenre}");
            Console.WriteLine($"Rating : {this.MovieRating}");           
        }

        public Review GetReview()
        {
            switch(this.MovieRating)
            {
                case Rating.OneStar:
                    return Review.VeryPoor; 

                case Rating.TwoStar:
                    return Review.BelowAverage;

                case Rating.ThreeStar:
                    return Review.Average;

                case Rating.FourStar:
                    return Review.Good;

                case Rating.FiveStar:
                    return Review.Excellant;

                default:
                    return Review.Average;

            }
        }
    }
}
