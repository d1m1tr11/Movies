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
        private string rating;

        public Movie_Class(string title, string director, string rating)
        {
            this.title = title;
            this.director = director;
            this.Rating = rating;
        }

        public string Rating
        {
            get { return this.rating; }

            set
            {
                if (value == "G" || value == "PG" || value == "GP-13" || value == "R" || value == "NR")
                {
                    this.rating = value;
                }
                else
                {
                    this.rating = "NR";
                }
            }
        }


    }
}
