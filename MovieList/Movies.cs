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
