using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class Movie_Class
    {
        public string title;
        public string director;
        public string rating;

        public Movie_Class(string title, string director, string rating)
        {
            this.title = title;
            this.director = director;
            this.rating = rating;
        }

        //public Movie_Class(string aTitle, string aDirector, string aRating)
        //{
        //    title = aTitle;
        //    director = aDirector;
        //    rating = aRating;
        //}
    }
}
