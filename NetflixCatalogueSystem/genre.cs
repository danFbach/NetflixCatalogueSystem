using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class genre
   {
        public List<title> titles = new List<title>();
        public string newGenre;        
        public genre(string newGenre)
        {
            this.newGenre = newGenre;
        }
        public static genre operator +(genre genre1, genre genre2)
        {
            return new genre(genre1.newGenre + genre2.newGenre);
        }            
        public static genre operator +(genre genre1, title titleIn)
        {
            return new genre(genre1.newGenre + titleIn.name);
        }        
        public void titleIterator()
        {
            foreach(title video in titles)
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