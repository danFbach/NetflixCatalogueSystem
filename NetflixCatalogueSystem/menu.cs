using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class menu
    {
        public void mainMenu()
        {
            view viewResults = new view();
            int menuChoice;

            Console.WriteLine("Please select an option. \n1) Get titles via 2 genres. \n2) Get titles via 1 title and 1 genre. \n3) Get new genre via 2 titles.");
            bool check = int.TryParse(Console.ReadLine(), out menuChoice);
            if (check.Equals(false)) { Console.WriteLine("Invalid selection."); mainMenu();  }         
            switch (menuChoice)
            {
                case (1):
                    viewResults.twoGenres();
                    return;
                case (2):
                    viewResults.titleGenre();
                    return;
                case (3):
                    viewResults.twoTitles();
                    return;
                default:
                    mainMenu();
                    break;
            }         
        }
    }
}