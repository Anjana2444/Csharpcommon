using MovieSystem;
MovieRating m1 = new MovieRating("Inception", 8.8, MovieGenre.SciFi);
MovieRating m2 = new MovieRating("The Dark Knight", 9.0, MovieGenre.Action);
MovieRating m3 = new MovieRating("The Godfather", 9.2, MovieGenre.Drama);
MovieRating m4 = new MovieRating("The Shawshank Redemption", 9.3, MovieGenre.Drama);
MovieRating m5 = new MovieRating("Pulp Fiction", 8.9, MovieGenre.Drama);

m1.PrintDetails();
Console.WriteLine($"Movie Rating Category: {m1.CheckRating()}");
m2.PrintDetails();
Console.WriteLine($"Movie Rating Category: {m2.CheckRating()}");
m3.PrintDetails();
Console.WriteLine($"Movie Rating Category: {m3.CheckRating()}");
m4.PrintDetails();
Console.WriteLine($"Movie Rating Category: {m4.CheckRating()}");
m5.PrintDetails();
Console.WriteLine($"Movie Rating Category: {m5.CheckRating()}");


//List<MovieRating> movierating = new List<MovieRating>();
//movierating.Add(m1);
//movierating.Add(m2);
//movierating.Add(m3);
//movierating.Add(m4);
//movierating.Add(m5);
//m1.ShowAddRemove(movierating);
//Console.WriteLine("Hello, World!");
