
using NetflixCatalogueSystem;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestProject1
{
    [TestClass]
    public class NetflixCatalogueTests
    {        
        [TestMethod]
        public void twoGenres()
        {
            List<Title> testTitles = new List<Title>();
            //arrange       
            testTitles.Add(new Movie("Happy Gilmore", 90, 4));
            testTitles.Add(new Show("South Park", 267));
            testTitles.Add(new Movie("Caddy Shack", 100, 3));
            testTitles.Add(new Movie("Mr.Deeds", 90, 3));
            testTitles.Add(new Movie("Ironman", 100, 5));
            testTitles.Add(new Movie("007", 90, 4));
            testTitles.Add(new Movie("Hell Boy", 120, 4));
            testTitles.Add(new Show("Mr.Robot", 10));
        
            Catalogue catalogue = new Catalogue();
            Genre com = catalogue.comedy;
            Genre act = catalogue.action;
            //act
            Genre newGenre = com + act;
            //assert
            for (int count = 0; count < testTitles.Count; count++)
            {
                CollectionAssert.Equals(testTitles[count],newGenre.titles[count]);
            }
        }
        [TestMethod]
        public void oneTitleOneGenre()
        {
            List<Title> testTitles = new List<Title>();
            testTitles.Add(new Movie("Ironman", 100, 5));
            testTitles.Add(new Movie("007", 90, 4));
            testTitles.Add(new Movie("Hell Boy", 120, 4));
            testTitles.Add(new Show("Mr.Robot", 10));
            testTitles.Add(new Show("South Park", 267));

            Catalogue catalogue = new Catalogue();
            Genre act = catalogue.action;

            Title title1 = catalogue.comedy.titles[1];
            Genre newGenre = act + title1;

            for(int count = 0; count < testTitles.Count; count++)
            {
                CollectionAssert.Equals(testTitles[count], newGenre.titles[count]);
            }

            
        }
    }
}
