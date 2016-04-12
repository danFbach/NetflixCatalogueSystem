using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class Genre
   {
        public List<Title> titles = new List<Title>();
        public string newGenre;        
        public Genre(string newGenre)
        {
            this.newGenre = newGenre;
        }
        public static Genre operator +(Genre genre1, Genre genre2)
        {
            Genre genreTemp = new Genre(genre1.newGenre + genre2.newGenre);
            genreTemp.titles.AddRange(genre1.titles);
            genreTemp.titles.AddRange(genre2.titles);
            return genreTemp;
        }
        public static Genre operator +(Genre genre1, Title titleIn)
        {
            Genre genreTemp = new Genre(genre1.newGenre + titleIn);
            genreTemp.titles.AddRange(genre1.titles);
            genreTemp.titles.Add(titleIn);
            return genreTemp;
        }
        public void titleIterator()
        {
            foreach(Title video in titles)
            {
            }
        }
    }
}