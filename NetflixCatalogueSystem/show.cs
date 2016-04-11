using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NetflixCatalogueSystem
{
    public class Show : Title
    {
        Episode showEpisodes = new Episode(null);
        List<Episode> episodes = new List<Episode>();
        new double rating;
        public Show(string name, int episodeQty)
        {
            episodes = newEpisode(episodeQty);
            this.name = name;
            rating = ratingAverage(episodes);
                     
        }
        public double ratingAverage(List<Episode> episodes)
        {
            int? tempTotal = 0;
            foreach (Episode ep in episodes)
            {
                tempTotal = tempTotal + ep.rating;
            }
            double seriesAverage = Convert.ToDouble(tempTotal / episodes.Count);
            return seriesAverage;
        }
        public override string ToString()
        {
            return (String.Format("{0}: {1} episodes Series Rating:{2}/10", name, episodes.Count,rating));
        }        
        public List<Episode> newEpisode(int episodeLimit)
        {
            List<Episode> newEpisodes = new List<Episode>();
            Random ratingGen = new Random();            
                for(int numberOfEpisodes = 0;numberOfEpisodes < episodeLimit; numberOfEpisodes++)
                {
                    int? newRating = ratingGen.Next(1, 10);
                    newEpisodes.Add(new Episode(newRating));
                Thread.Sleep(5);
                }
            return newEpisodes;
        }
    }
}
//  Show(inherits from Title)
//      -Contains a list of Episodes
//      -Overrides parent’s Rating to return an aggregated rating of Episode ratings
//      -Overrides ToString() method to return a string of the name of the show and number of episodes