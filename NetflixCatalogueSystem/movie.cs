using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public abstract class movie : title
    {
        
        title movieTitle;
        public movie(string title1, Enum genre1) : base(title1,genre1)
        {
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public void duration()
        {

        }
    }
}
//  Movie(Inherits from Title)
//      -Duration field
//      -Overrides ToString() method to return a string of the name and duration of the movie
