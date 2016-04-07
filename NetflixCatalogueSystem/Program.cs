using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            genre add = new genre();

            Console.WriteLine("7 all, 6 romantic com, 5 romance action, 4 romance, 3 comedy action, 2 comedy, 1 action \nPick number.");
            int choice;
            int.TryParse(Console.ReadLine(), out choice);
            add.test(choice);
            Console.ReadKey();
        }
    }
}
    //  Netflix Catalogue System
    //  Console application with the following items:
    //  Other project requirements:
    //      -Utilize the null operators we covered in class
    //      -Utilize appropriate access modifiers
    //      -Create at least 5 unit tests
    //      -Show the program in use.Essentially, there needs to be data, run the program, and print to the console to show that the program works.
    //  There are plenty of opportunities to implement the tools you learned this week.With that said, remember to always use the right tool for the job.


    //genre