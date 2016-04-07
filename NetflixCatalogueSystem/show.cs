using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class show : title
    {
        episode episode = new episode();
        List<episode> episodes = new List<episode>();
        public show(string title1, Enum genre1) : base(title1,genre1)
        {

        }
        public override void rating()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
//  Show(inherits from Title)
//      -Contains a list of Episodes
//      -Overrides parent’s Rating to return an aggregated rating of Episode ratings
//      -Overrides ToString() method to return a string of the name of the show and number of episodes