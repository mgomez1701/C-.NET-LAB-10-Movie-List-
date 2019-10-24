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
                new string ("Horror"),
                new string ("Drama"),
                new string ("Animation"),
                new string ("Scifi"),

            };

            Console.WriteLine("Hello! We have many movies! What catagory are you interetsed in?");
            Console.WriteLine("Please select from the following catagories");
            Movies.PrintCategoryList(catagories);
        }

    }
}
