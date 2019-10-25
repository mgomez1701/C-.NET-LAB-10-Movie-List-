using System;
using System.Collections.Generic;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movies> movieList = new List<Movies>
            {
                new Movies("Midsommer","Horror"),
                new Movies("Heriditary", "Horror"),
                new Movies("Once Upon a Time in Hollywood", "Drama"),
                new Movies("The Dark Knight Rises", "Drama"),
                new Movies("Surfs Up", "Animated"),
                new Movies("Antz" , "Animated"),
                new Movies("Intersteller", "Scifi"),
                new Movies("Star Wars The Revenge of The Sith", "Scifi"),
                new Movies("Wolf of Wall Street", "Drama"),
                new Movies("Django Unchained Director Cut Unedited Version", "Drama"),
            };

            List<string> catagories = new List<string> // how would i make this a private method
            {
                new string ("1).Horror"),
                new string ("2).Drama"),
                new string ("3).Animation"),
                new string ("4).Scifi"),

            };
            bool keepGoing = true;
            Console.WriteLine("Hello! We have many movies! What catagory are you interetsed in?");

            while (keepGoing)
            {
                Movies.PrintCategoryList(catagories);
                int index = Movies.ValidateRange(" You can choose a category by entering a number 1 - 4)", 0, catagories.Count);

                if(index == 1)
                {
                    Movies.HorrorMovies(index);
                }
                else if (index == 2)
                {
                    Movies.DramaMovies(index);
                }
                else if (index == 3)
                {
                    Movies.AnimatedMovies(index);                    
                }
                else if (index == 4)
                {
                    Movies.ScifiMovies(index);
                }
                else
                {
                    Movies.ValidateRange(" You can choose a category by entering a number 1 - 4)", 0, catagories.Count);
                }
                keepGoing= Movies.GetContinue(); // here is where i have my false input if the user says no 
                

            }

            
        }

    }
}
