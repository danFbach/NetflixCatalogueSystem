using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class Menu
    {
        public void mainMenu()
        {
            View viewResults = new View();
            int menuChoice;
            Console.WriteLine("Please select an option. \n1) Get titles via 2 genres. \n2) Get titles via 1 title and 1 genre. \n3) Get new genre via 2 titles.");
            bool check = int.TryParse(Console.ReadLine(), out menuChoice);
            if (check.Equals(false)) { Console.WriteLine("Invalid selection."); mainMenu();  }         
            switch (menuChoice)
            {
                case (1):
                    viewResults.twoGenres();
                    continueProgram();
                    mainMenu();
                    return;
                case (2):
                    viewResults.oneGenreOneTitle();
                    continueProgram();
                    mainMenu();
                    return;
                case (3):
                    viewResults.twoTitles();
                    continueProgram();
                    mainMenu();
                    return;
                case (4):
                    break;
                default:
                    mainMenu();
                    break;
            }
        }
        public void continueProgram()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please press enter to return to main menu.");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }
    }
}