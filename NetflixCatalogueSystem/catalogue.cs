
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class catalogue
    {
        genre action = new genre();
        genre comedy = new genre();
        genre romance = new genre();

        public void newTitles()
        {
            comedy.titles.Add(new movie("Happy Gilmore",90,4));
            comedy.titles.Add(new show("South Park",4));
            action.titles.Add(new movie("Hell Boy", 120, 4));
            romance.titles.Add(new movie("Phantom of the Opera", 180, 3));
        }
    }
}
