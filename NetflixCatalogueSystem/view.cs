using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class View {
            Catalogue start = new Catalogue();
        public View()
        {
            start.actionTitles();
            start.comedies();
            start.Romantic();    
        }
        public void twoTitles()
        {
            listTitles();
            Title selection1 = titleSelection();
            Title selection2 = titleSelection();
            Genre newGenre = selection1 + selection2;
            foreach(Title video in newGenre.titles)
            {
                Console.WriteLine(video);
            }
            

        }
        public void oneGenreOneTitle()
        {
            string genreChoice = selectGenre();
            Genre genre1 = genreReturn(genreChoice);
            listTitles();
            Title selection = titleSelection();
            Genre newGenre = genre1 + selection;
            foreach(Title video in newGenre.titles)
            {
                Console.WriteLine(video);
            }
        }        
        public void twoGenres()
        {
            string genreChoice1 = selectGenre();
            Genre Genre1 = genreReturn(genreChoice1);
            string genreChoice2 = selectGenre();
            Genre Genre2 = genreReturn(genreChoice2);
            Genre newGenre = Genre1 + Genre2;
            foreach (Title video in newGenre.titles)
            {
                Console.WriteLine(video);
            }
        }
        public Genre genreReturn(string genreChoice)
        {
            switch (genreChoice)
            {
                case ("comedy"):
                    return start.comedy;
                case ("action"):
                    return start.action;
                case ("romantic"):
                    return start.romantic;
                default:
                    return null;
            }
        }
        public string selectGenre()
        {
            string genreChoice = "";
            Console.WriteLine("Please enter a genre. [Action, Comedy, Romantic]");
            genreChoice = Console.ReadLine();
            genreChoice = genreChoice.ToLower();
            if (genreChoice != "comedy" && genreChoice != "action" && genreChoice != "romantic")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ivalid Genre.\n\r");
                Console.ForegroundColor = ConsoleColor.White;
                return selectGenre();
            }
            return genreChoice;
        }
        public Title titleSelection()
        {
            string titleEntry = "";
            Genre allGenre = start.comedy + start.action + start.romantic;
            
            Console.WriteLine("Please select one.");
            titleEntry = Console.ReadLine();
            titleEntry = titleEntry.ToLower();
            foreach(Title video in allGenre.titles)
            {
                string comparison = video.name.ToLower();
                if (titleEntry.Equals(comparison))
                {
                    return video;
                }
            }
            Console.WriteLine("Invalid title.");
            return titleSelection();
        }
        public void listTitles()
        {
            Console.WriteLine("Here is a list of available titles. ");
            Genre allGenre = start.comedy + start.action + start.romantic;
            foreach (Title video in allGenre.titles)
            {
                Console.WriteLine("{0}, ", video.name);
            }
        }
    }
}

//  View
//    -Prints out the various Genres and their Titles 