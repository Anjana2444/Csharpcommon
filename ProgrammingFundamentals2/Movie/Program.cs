using Movie;
Console.WriteLine("Here we rate movies");
Console.WriteLine("");

Rating r1 = new Rating(1, "Bahubali 1", 3, "Epic action fantasy", MovieRating.Excellent);
r1.Displaydetails();
r1.RatingOfMovie();

Console.WriteLine("");

Rating r2 = new Rating(2, "Eega", 2, "Fantasy and action", MovieRating.Good);
r2.Displaydetails();
r2.RatingOfMovie();

Console.Read();