using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class Movie : Title
    {
        public int duration;
        public Movie(string name, int duration, int? rating)
        {
           // this.currentGenre = currentGenre;
            this.duration = duration;
            this.rating = rating;
            this.name = name;
        }
        public override string ToString()
        {
            return (String.Format("{0}: {1}m", name, duration));
        }
    }
}
//  Movie(Inherits from Title)
//      -Duration field
//      -Overrides ToString() method to return a string of the name and duration of the movie
