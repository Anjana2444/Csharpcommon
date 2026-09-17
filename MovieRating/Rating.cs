using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRating
{
    internal enum Rate { VeryBad, Bad, Mid, Good, VeryGood }
    internal enum Genre { Romantic, Comedy, RomCom, SciFi }
    internal class Rating
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public DateOnly MovieReleaseDate { get; set; }
        public int Budget { get; set; }
        public Rate MovieRating { get; set; }
        public  Genre MovieGenre { get; set; }

        public Rating(int movei_id, string movie_name, DateOnly release_date, int budget, Rate rate, Genre genre)
        {
            this.MovieID = movei_id;
            this.MovieName = movie_name;
            this.MovieReleaseDate = release_date;
            this.Budget = budget;
            this.MovieRating = rate;
            this.MovieGenre = genre;
        }
        public void PrintMovieDetials()
        {
            Console.WriteLine($"Movie ID: {this.MovieID}\nMovie Name: {this.MovieName}\nRelease Date: {this.MovieReleaseDate}\nBudget: {this.Budget}\nRating: {this.MovieRating}\nGenre: {this.MovieGenre}");
        }
        public void PrintRatingDetials()
        {
            if (this.MovieRating==Rate.VeryBad)
            {
                Console.WriteLine("Very Bad Movie!!!");
            }
            else if (this.MovieRating == Rate.Bad)
            {
                Console.WriteLine("Bad Movie!!!");
            }
            else if (this.MovieRating == Rate.Mid)
            {
                Console.WriteLine("Mid Average Movie!!!");
            }
            else if (this.MovieRating == Rate.Good)
            {
                Console.WriteLine("Good Movie!!!");
            }
            else if (this.MovieRating == Rate.VeryGood)
            {
                Console.WriteLine("Very Good Movie!!!");
            }
        }
        public void PrintGenreDetails()
        {
            switch(this.MovieGenre)
            {
                case Genre.Romantic:
                    Console.WriteLine("A Romantic Movie");
                    break;
                case Genre.SciFi:
                    Console.WriteLine("A SciFi Movie");
                    break;
                case Genre.Comedy:
                    Console.WriteLine("A Comedy Movie");
                    break;
                case Genre.RomCom:
                    Console.WriteLine("A RomCom Movie");
                    break;
            }
        }
    }
}
