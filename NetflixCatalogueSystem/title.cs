using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class title
    {
        public string mainTitle;
        public string titleGenre;
        public double rating;
        genre genre = new genre();
        public title(string mainTitle, string titleGenre, double rating)
        {
            this.titleGenre = titleGenre;
            this.rating = rating;
            this.mainTitle = mainTitle;
        }
        public static title operator +(title title1, title title2)
        {
            title tempTitle = title1 + title2;
            return tempTitle;
        }
        public void name()
        {
        }
    }
}
//  Title
//      -Name field
//      -Rating field
//      -Overload plus(+) operator to take in two Titles and return an aggregated Genre
//      -Offer two overloaded constructors: one that takes in all the fields and sets them, another that takes in no fields and sets the internal fields to null.