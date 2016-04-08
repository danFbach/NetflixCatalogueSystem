using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class show : title
    {
        episode showEpisodes = new episode();
        List<episode> episodes = new List<episode>();
        public show(string name, int rating)
        {
            List<episode> episodes = new List<episode>();
            this.episodes = episodes;
            this.rating = rating;
            this.name = name;         
        }
        public override string ToString()
        {
            return (String.Format("{0}: {1} episodes", name, episodes.Count));
        }
        public void averageRating()
        {
            int? rating = 0;
            foreach(episode video in episodes)
            {
                rating += video.rating;
            }
            rating = (rating / episodes.Count);
            this.rating = rating;
        }
    }
}
//  Show(inherits from Title)
//      -Contains a list of Episodes
//      -Overrides parent’s Rating to return an aggregated rating of Episode ratings
//      -Overrides ToString() method to return a string of the name of the show and number of episodes