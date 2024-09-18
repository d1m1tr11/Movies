using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class Series_SubClass : Movie_Class
    {
        public int seriesCount;

        //public Series_SubClass(string title, string director, string rating, int seriesCount)
        //   : base(title, director, rating)
        //{
        //    this.seriesCount = seriesCount;
        //}


        public Series_SubClass(string title, string director, string rating, int seriesCount)
           : base(title, director, rating) => this.seriesCount = seriesCount;

    }

 
}
