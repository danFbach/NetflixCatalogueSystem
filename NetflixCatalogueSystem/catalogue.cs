using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class catalogue
    {
        genre action = new genre("Action");
        genre comedy = new genre("Comedy");
        genre romance = new genre("Romance");

        public List<title> comedies()
        {
            comedy.titles.Add(new movie("Happy Gilmore", 90, 4));
            comedy.titles.Add(new show("South Park", 4));
            comedy.titles.Add(new movie("Caddy Shack", 100, 3));
            comedy.titles.Add(new movie("Mr.Deeds", 90, 3));
            return comedy.titles;
        }
        public List<title> actionTitles()
        {
            action.titles.Add(new movie("Ironman", 100, 5));
            action.titles.Add(new movie("007", 90, 4));
            action.titles.Add(new movie("Hell Boy", 120, 4));
            return action.titles;
        }
        public List<title> romantic()
        {
            romance.titles.Add(new movie("Phantom of the Opera", 160, 4));
            return romance.titles;
        }
    }
}
