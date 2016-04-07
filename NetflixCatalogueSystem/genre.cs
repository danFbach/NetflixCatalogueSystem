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
        public static string operator +(genre genre1, genre genre2)
        {
            foreach(title movie in genre1)
            {
                Console.Write(genre1.GetType());
            }
        }
        public static genre operator +(genre choice,title titleIn)
        {
            int genreNumb = titleIn.genre1;
            genre newGenre = new genre();
            return newGenre;            
        }                                                                            
        public int titleIterator(title titleIn)
        {
            int genreNumberIn;
            List<title> tempTitles = new List<title>();
            foreach(title movie in titles)
            {
                if (movie.Equals(titleIn))
                {
                    return movie.genre1;
                }
            }return 0;
        }
        public string aggregatedGenre(int genreNumberIn)
        {
            int actionNum = (int)genreNum.action;
            int romanceNum = (int)genreNum.Romance;
            int comedyNum = (int)genreNum.Comedy;
            string genreName = "";
            if (genreNumberIn >= romanceNum)
            {
                genreName += genreNum.Romance + " ";
                genreNumberIn -= 4;
            }
            if (genreNumberIn >= comedyNum)
            {
                genreName += genreNum.Comedy + " ";
                genreNumberIn -= 2;
            }
            if (genreNumberIn >= actionNum)
            {
                genreName += genreNum.action;
                genreNumberIn -= 1;
            }
            return genreName;
        }
        public void addTitlesToList(string title1, Enum titleGenre)
        {
            for(int i = 0;i < 20; i++)
            {
                titles.Add(new title(title1, titleGenre));
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