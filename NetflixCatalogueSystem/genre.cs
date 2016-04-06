using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class genre
    {
        List<title> titles = new List<title>();

        public void addNewTitles()
        {
            foreach(action movie in action)
            {
                titles.Add(new action());
            }
        }

        public void titleIterator()
        {
            foreach(title movie in titles)
            {

            }
        }

    }
}
