using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSystem
{
    internal enum MovieGenre { Action, Comedy, Drama, Horror, Romance, SciFi }
    internal enum MovieRatingCategory { Poor, Average, Good, Excellent }
    internal class MovieRating
    {
        public string MovieName { get; set; }
        public double Rating { get; set; }
        public MovieGenre Genre { get; set; }


        public MovieRating(string MovieName, double Rating, MovieGenre Genre)
        {
            this.MovieName = MovieName;
            this.Rating = Rating;
            this.Genre = Genre;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Movie Name: {this.MovieName}, Rating: {this.Rating}, Genre: {this.Genre}");
        }

        public MovieRatingCategory CheckRating()
        {
            if (this.Rating > 8.0)
            {
 
                return MovieRatingCategory.Excellent;
            }
            else if (this.Rating > 6.5 && this.Rating <= 8.0)
            {
                return MovieRatingCategory.Average;
            }
            else if (this.Rating > 9.0)
            {
                return MovieRatingCategory.Excellent;
            }
            else
            {
                return MovieRatingCategory.Poor;
            }


        }
        //public void showListOfMovies(List<MovieRating> movies)
        //{
        //    foreach (MovieRating movie in movies)
        //    {
        //        Console.WriteLine($"Movie Name: {movie.MovieName}, Rating: {movie.Rating}, Genre: {movie.Genre}, Movie Rating Category: {movie.CheckRating()}");
        //    }
        //}

        //public void AddMovieToList(List<MovieRating> movies, MovieRating movie, MovieGenre genre)
        //{
        //    movies.Add(movie);
        //}

        //public void RemoveMovieFromList(List<MovieRating> movies, MovieRating movie, MovieGenre genre)
        //{
        //    movies.Remove(movie);
        //}

        //public void ShowAddRemove(List<MovieRating> movies)
        //{
        //    int choice = -1;
        //    while (choice != 0)
        //    {
        //        Console.WriteLine("1. Show Movies");
        //        Console.WriteLine("2. Add Movie");
        //        Console.WriteLine("3. Remove Movie");
        //        choice = Convert.ToInt32(Console.ReadLine());

        //        switch (choice)
        //        {
        //            case 1:
        //                showListOfMovies(movies);
        //                break;
        //            case 2:
        //                Console.WriteLine("Enter Movie Name:");
        //                string movieName = Console.ReadLine();
        //                Console.WriteLine("Enter Movie Rating:");
        //                double movieRating = Convert.ToDouble(Console.ReadLine());
        //                Console.WriteLine("Enter Movie Genre:");
        //                MovieGenre movieGenre = (MovieGenre)Enum.Parse(typeof(MovieGenre), Console.ReadLine());
        //                movies.Add(new MovieRating(movieName, movieRating, movieGenre));
        //                break;
        //            case 3:
        //                Console.WriteLine("Remove Movie");
        //                Console.WriteLine("Enter Movie Name:");
        //                string movieName1 = Console.ReadLine();
        //                var movieToRemove = movies.FirstOrDefault(m => m.MovieName == movieName1);
        //                if (movieToRemove != null)
        //                {
        //                    movies.Remove(movieToRemove);
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Movie not found.");
        //                }
        //                break;
        //            default:
        //                Console.WriteLine("Invalid Choice");
        //                break;
        //        }
        //    }
        //}

        //public void GetGenre()
        //{
        //    switch (this.Genre)
        //    {
        //        case MovieGenre.Action:
        //            Console.WriteLine("Action Movie");
        //            break;
        //        case MovieGenre.Comedy:
        //            Console.WriteLine("Comedy Movie");
        //            break;
        //        case MovieGenre.Drama:
        //            Console.WriteLine("Drama Movie");
        //            break;
        //        case MovieGenre.Horror:
        //            Console.WriteLine("Horror Movie");
        //            break;
        //        case MovieGenre.Romance:
        //            Console.WriteLine("Romance Movie");
        //            break;
        //        case MovieGenre.SciFi:
        //            Console.WriteLine("Sci-Fi Movie");
        //            break;
        //        default:
        //            Console.WriteLine("Unknown Genre");
        //            break;
        //    }

        //}

    }
}
