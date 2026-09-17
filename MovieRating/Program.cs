using MovieRating;

Console.WriteLine("===MOVIE RATING===");
DateOnly d1 = new DateOnly(2014,11,07);
Rating m1 = new Rating(101, "Interstellar",d1,1400000,Rate.VeryGood,Genre.SciFi);
m1.PrintMovieDetials();
m1.PrintRatingDetials();
m1.PrintGenreDetails();