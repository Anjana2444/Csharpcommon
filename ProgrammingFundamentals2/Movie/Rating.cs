using System;
using System.Collections.Generic;
using System.Text;

namespace Movie
{
    internal enum MovieRating { Excellent, Good, Average, Poor }
    internal class Rating
    {
        public int Index { get; set; }
        public string Moviename { get; set; }

        public float Duration { get; set; }

        public string Moviegenre { get; set; }

        public MovieRating Movierating {  get; set; }

        public Rating(int index, string moviename, float duration, string moviegenre, MovieRating movierating)
        {
            this.Index = index;
            this.Moviename = moviename;
            this.Duration = duration;
            this.Moviegenre = moviegenre;
            this.Movierating = movierating;
        }

        public void Displaydetails()
        {
            Console.WriteLine($"Index: {this.Index}");
            Console.WriteLine($"Movie Name: {this.Moviename}");
            Console.WriteLine($"Duration: {this.Duration}hrs");
            Console.WriteLine($"Genre: {this.Moviegenre}");
            Console.WriteLine($"Rating: {this.Movierating}");
        }

        public void RatingOfMovie()
        {
            switch (this.Movierating)
            {
                case MovieRating.Excellent:
                    Console.WriteLine("Excellent movie, great story and screenplay");
                    break;

                case MovieRating.Good:
                    Console.WriteLine("Good movie, with a great screenplay");
                    break;

                case MovieRating.Average:
                    Console.WriteLine(" A one time watch");
                    break;

                case MovieRating.Poor:
                    Console.WriteLine("Waste of time and money");
                    break;
            }
        }

    }
}
