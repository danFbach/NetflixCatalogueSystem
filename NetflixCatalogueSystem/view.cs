using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class View
    {
        Catalogue catalogue = new Catalogue();
        public void twoTitles()
        {
            listTitles();
            Title selection1 = titleSelection();
            Title selection2 = titleSelection();
            Genre newGenre = selection1 + selection2;
            foreach (Title video in newGenre.titles)
            {
                if (catalogue.comedy.titles.Contains(video))
                {
                    Console.Write("Comedy ");
                }
                else if (catalogue.action.titles.Contains(video))
                {
                    Console.Write("Action ");
                }
                else if (catalogue.romantic.titles.Contains(video))
                {
                    Console.Write("Romantic ");
                }
            }
        }
        public void oneGenreOneTitle()
        {
            string genreChoice = selectGenre();
            Genre genre1 = getGenre(genreChoice);
            listTitles();
            Title selection = titleSelection();
            Genre newGenre = genre1 + selection;
            foreach (Title video in newGenre.titles)
            {
                Console.WriteLine(video);
            }
        }
        public void twoGenres()
        {
            string genreChoice1 = selectGenre();
            Genre Genre1 = getGenre(genreChoice1);
            string genreChoice2 = selectGenre();
            Genre Genre2 = getGenre(genreChoice2);
            Genre newGenre = Genre1 + Genre2;
            foreach (Title video in newGenre.titles)
            {
                Console.WriteLine(video);
            }
        }
        public Genre getGenre(string genreChoice)
        {
            switch (genreChoice)
            {
                case ("comedy"):
                    return catalogue.comedy;
                case ("action"):
                    return catalogue.action;
                case ("romantic"):
                    return catalogue.romantic;
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
            Genre allGenre = catalogue.comedy + catalogue.action + catalogue.romantic;

            Console.WriteLine("Please select one.");
            titleEntry = Console.ReadLine();
            titleEntry = titleEntry.ToLower();
            foreach (Title video in allGenre.titles)
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
            Genre allGenre = catalogue.comedy + catalogue.action + catalogue.romantic;
            foreach (Title video in allGenre.titles)
            {
                Console.WriteLine("{0}, ", video.name);
            }
        }
    }
}