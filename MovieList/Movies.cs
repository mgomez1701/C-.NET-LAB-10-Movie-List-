using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieList
{
 
    
    class Movies
    {
       
            
        #region field
        private string title;
        private string category;
        

        #endregion

        #region properties
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        #endregion

        public Movies()
        {

        }
        public Movies(string _title, string _category)
        {
            title = _title;
            category = _category;
        }

        public Movies(string _category)
        {
           
            category = _category;
        }
        public static List<string> PrintCategoryList(List<string> catagory)
        {
            for (int i = 0; i < catagory.Count; i++)
            {
                Console.WriteLine($"{catagory[i]}");
            }
            return catagory;

        }

        public static int ValidateRange(string message, int min, int max) // used this instead of a try catch
        {
            int number = ParseInput(message);
            if (number > min && number <= max)
            {
                return number;

            }
            else
            {
                return ValidateRange(message, min, max);
            }

        }

        public static int ParseInput(string message)
        {
            try
            {
                string input = GetUserInput(message);
                int number = int.Parse(input);
                return number;
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Not in the correct format");
                return ParseInput(message);
            }
            catch
            {
                return ParseInput(message);
            }
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine().ToLower();
        }

        public static void HorrorMovies (int number)
        {
            int index = number;
            
            {
                Console.WriteLine("Midsommer");
                Console.WriteLine("Hereditary");
            }
        }

        public static void DramaMovies(int number)
        {
            int index = number;

            {
                Console.WriteLine("Once Upon a Time in Hollywood");
                Console.WriteLine("The Dark Knight Rises");
                Console.WriteLine("Wolf of Wall Street");
                Console.WriteLine("Django Unchained Director Cut Unedited Version");
            }
        }

        public static void AnimatedMovies(int number)
        {
            int index = number;

            {
                Console.WriteLine("Surfs Up");
                Console.WriteLine("Antz");
                
            }
        }

        public static void ScifiMovies(int number)
        {
            int index = number;

            {
                Console.WriteLine("Intersteller");
                Console.WriteLine("Star Wars The Revenge of The Sith");
            }
        }

        public static bool GetContinue()
        {
            bool letsGo = true;
            Console.WriteLine($"Do you want to check out other movies in other catagories? Select Y/N");
            string userContinue = Console.ReadLine();
            switch(userContinue.ToLower())
            {
                case "y":
                    return letsGo;
                case "n":
                    return false;
                default:
                    return GetContinue();
            }

        }


        //public static List<string> GetCatagories(List<Movies>movies)
        //{
        //    List<string> categories = new List<string>();
        //    foreach(Movies flicks in movies)
        //    {
        //        if (!categories.Contains(flicks.Category))
        //        {
        //            categories.Add(flicks.Category);

        //        }
        //    }
        //    return categories;
        //}


    }
}
