using System;
using System.Collections.Generic;
using System.Text;

namespace If_Switch
{
    class Magazine
    {
        private string magazineTitle;

        public string MagazineTitle
        {
            get { return magazineTitle; }
            set { magazineTitle = value; }
        }
        private Person.Frequency releaseFrequency;

        public Person.Frequency ReleaseFrequency
        {
            get { return releaseFrequency; }
            set { releaseFrequency = value; }
        }
        private System.DateTime releaseDate;
        public System.DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
        private int edition;

        public int Edition
        {
            get { return edition; }
            set { edition = value; }
        }
        private Article listOfArticles;

        public Article ListOfArticles
        {
            get { return listOfArticles; }
            set { listOfArticles = value; }
        }
        public Magazine(string magazineTitle, Person.Frequency releaseFrequency, System.DateTime releaseDate, int edition)
        {
            MagazineTitle = magazineTitle;
            ReleaseFrequency = releaseFrequency;
            ReleaseDate = releaseDate;
            Edition = edition;
        }
        public Magazine() 
        {
            MagazineTitle = "Some default title";
            ReleaseFrequency = Person.Frequency.Weekly;
            ReleaseDate = System.DateTime.Now;
            Edition = 0;
        }
        private double ratingCalculation;

        public double RatingCalculation
        {
            get { return 5678; }
        }


    }
}
