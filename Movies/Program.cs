using Movies;


// G, PG, PG-13, R, NR


var shrek = new Movie_Class("Shrek", "Rejisori2", "PG");

//shrek.Rating = "ADWFAWF";


var supernatural = new Series_SubClass("supernatural", "Rejisori1", "PG-13", 450);


Console.WriteLine(shrek.title + " " + shrek.director + " " + shrek.Rating);
Console.WriteLine(Movie_Class.movieCount);



