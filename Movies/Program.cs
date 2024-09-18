using Movies;


// G, PG, PG-13, R, NR


var shrek = new Movie_Class("Shrek", "Rejisori2", "PG");

shrek.Rating = "ADWFAWF";


Console.WriteLine(shrek.title + " " + shrek.director + " " + shrek.Rating);
Console.WriteLine(Movie_Class.movieCount);


