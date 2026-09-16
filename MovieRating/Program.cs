using MovieRating;
MovieRanking m1 = new MovieRanking(01, "Memories", 230, MovieRatings.Average);
MovieRanking m2 = new MovieRanking(02, "SpiderMan", 230, MovieRatings.Excellent);
MovieRanking m3 = new MovieRanking(03, "BKU", 230, MovieRatings.Excellent);
MovieRanking m4 = new MovieRanking(04, "Asha", 230, MovieRatings.Poor);
int choice;
do
{
    Console.WriteLine("Movie Review");
    Console.WriteLine("1.MEMORIES");
    Console.WriteLine("2.SPIDERMAN");
    Console.WriteLine("3.BKU");
    Console.WriteLine("4.ASHA");
    Console.WriteLine("Enter the choice you want");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            m1.DiplayDetails();
            m1.DisplayRating();
            break;
        case 2:
            m2.DiplayDetails();
            m2.DisplayRating();
            break;
        case 3:
            m3.DiplayDetails();
            m3.DisplayRating();
            break;
        case 4:
            m4.DiplayDetails();
            m4.DisplayRating();
            break;


        case 5:
            Console.WriteLine("end");
            break;


    }


}while(choice != 5) ;


//m1.DiplayDetails();
//m1.DisplayRating();
//Console.WriteLine();
//m2.DiplayDetails();
//m2.DisplayRating();
//Console.WriteLine();
//m3.DiplayDetails();
//m3.DisplayRating();






