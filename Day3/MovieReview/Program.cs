using MovieReview;

Movie m1 = new Movie(101, "Interstellar", Rating.FiveStar, Genre.Drama);
Movie m2 = new Movie(102, "Drishyam", Rating.FourStar, Genre.Thriller);
Movie m3 = new Movie(103, "Balan", Rating.ThreeStar, Genre.Thriller);
Movie m4 = new Movie(104, "Titanic", Rating.FiveStar, Genre.Drama);
Movie m5 = new Movie(105, "Alone",Rating.TwoStar, Genre.Drama);

m1.PrintDetails();
Console.WriteLine($"Review : {m1.GetReview()}");
Console.WriteLine();

m2.PrintDetails();
Console.WriteLine($"Review : {m2.GetReview()}");
Console.WriteLine();

m3.PrintDetails();
Console.WriteLine($"Review : {m3.GetReview()}");
Console.WriteLine();

m4.PrintDetails();
Console.WriteLine($"Review : {m4.GetReview()}");
Console.WriteLine();

m5.PrintDetails();
Console.WriteLine($"Review : {m5.GetReview()}");
Console.ReadLine();
