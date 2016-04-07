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
        public genre()
        {
        }
        public enum genreNum
        {
            action = 1,
            Comedy = 2,
            Romance = 4
        }
        
        public static genre operator +(, genre genre2)
        { 
            return genre1;
        }
        public static genre operator +(genre choice,title titleIn)
        {
            return choice;
        }                                                                            
        public void titleIterator(title titleIn)
        {
            foreach(movie movies in titles)
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
//      -Create the genres: All, Romance, Action, Comedy.They need to share some titles (such as Romantic Comedies) by reference, not by duplicating the title itself.


//public string aggregatedGenre(int genreNumberIn)
//{
//    int actionNum = (int)genreNum.action;
//    int romanceNum = (int)genreNum.Romance;
//    int comedyNum = (int)genreNum.Comedy;
//    string genreName = "";
//    if (genreNumberIn >= romanceNum)
//    {
//        genreName += genreNum.Romance + " ";
//        genreNumberIn -= 4;
//    }
//    if (genreNumberIn >= comedyNum)
//    {
//        genreName += genreNum.Comedy + " ";
//        genreNumberIn -= 2;
//    }
//    if (genreNumberIn >= actionNum)
//    {
//        genreName += genreNum.action;
//        genreNumberIn -= 1;
//    }
//    return genreName;
//}
//public void addTitlesToList(string title1, Enum titleGenre)
//{
//    for (int i = 0; i < 20; i++)
//    {
//        titles.Add(new movie("Hellboy", 120, 4, 1));
//        titles.Add(new movie("007", 90, 4, 5));
//        titles.Add(new movie("Caddy Shack", 100, 3, 2));
//        titles.Add(new movie("Phantom of the Opera", 160, 4, 4));
//        titles.Add(new movie("50 first dates", 90, 3, 6));
//        titles.Add(new movie("The WaterBoy", 90, 3, 2));
//        titles.Add(new movie("Live free or Die Hard", 120, 4, 1));
//        titles.Add(new movie("Ironman", 100, 5, 1));
//        titles.Add(new movie("Mr.Deeds", 90, 3, 6));
//    }
//}