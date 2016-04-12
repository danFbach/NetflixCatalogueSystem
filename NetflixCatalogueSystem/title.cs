using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public abstract class Title
    {
        public string name;
        public int? rating;
        //public Title currentGenre;
        public Title(string name, int? rating)
        {
            this.name = name;
            this.rating = rating;
        }
        public Title()
        {
            name = null;
            rating = null;
        }
        public static Genre operator +(Title title1, Title title2)
        {
            Genre newGenre = new Genre(title1.name + title2.name);
            newGenre.titles.Add(title1);
            newGenre.titles.Add(title2);
            return newGenre;
        }              
    }
}