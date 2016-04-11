using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class Catalogue
    {
        public Genre action = new Genre("Action");
        public Genre comedy = new Genre("Comedy");
        public Genre romantic = new Genre("Romantic");
        public Catalogue()
        {
            addComedies();
            addAction();
            addRomantic();
        }
        public void addComedies()
        {
            comedy.titles.Add(new Movie("Happy Gilmore", 90, 4));
            comedy.titles.Add(new Show("South Park", 267));
            comedy.titles.Add(new Movie("Caddy Shack", 100, 3));
            comedy.titles.Add(new Movie("Mr.Deeds", 90, 3));
        }
        public void addAction()
        {
            action.titles.Add(new Movie("Ironman", 100, 5));
            action.titles.Add(new Movie("007", 90, 4));
            action.titles.Add(new Movie("Hell Boy", 120, 4));
            action.titles.Add(new Show("Mr.Robot", 10));
        }
        public void addRomantic()
        {
            romantic.titles.Add(new Movie("Phantom of the Opera", 160, 4));
        }        
    }
}