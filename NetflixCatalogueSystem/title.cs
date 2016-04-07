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
        public int genre1;
        genre genre = new genre();
        public title(string title1, Enum titleGenre)
        {
            mainTitle = title1;
        }
        string titleGenre;
        string strTitle;
        public static title operator +(title title1, title title2)
        {
            title tempTitle = title1 + title2;
            return tempTitle;
        }
        public void name()
        {
        }
        public virtual void rating()
        {            
        }
    }
}
//  Title
//      -Name field
//      -Rating field
//      -Overload plus(+) operator to take in two Titles and return an aggregated Genre
//      -Offer two overloaded constructors: one that takes in all the fields and sets them, another that takes in no fields and sets the internal fields to null.