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
//  Genre 
//      -Contains a list of Titles
//      -Implement custom iterator to iterate over those Titles
//      -Overload plus(+) operator to take in two Genres and return the aggregated Genre.
//          o For example, if we want to create an aggregated genre Romantic Comedy, all the film titles in that specific genre would include film titles from Romance and film titles from Comedy.
//      -Overload plus (+) operator to take in a Genre and a Title to return the aggregated Genre.
//          o Take in a title, add it to the genre, return an aggregated list.
//          o For example, title Die Hard and genre Comedy would return a list of all comedy films and Die Hard.
//      -Create the genres: All, Romance, Action, Comedy

