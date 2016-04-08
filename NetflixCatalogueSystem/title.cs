using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class title
    {
        public catalogue newCatalogue = new catalogue();
        public string name;
        public int? rating;
        public title(string name, int? rating)
        {
            this.name = name;
            this.rating = rating;
        }
        public title()
        {
            name = null;
            rating = null;
        }
        public static title operator +(title title1, title title2)
        {
            return new title("",0);
        }              
    }
}
//  Title
//      -Name field
//      -Rating field
//      -Overload plus(+) operator to take in two Titles and return an aggregated Genre
//      -Offer two overloaded constructors: one that takes in all the fields and sets them, another that takes in no fields and sets the internal fields to null.