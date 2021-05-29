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
        private List<Article> listOfArticles;

        public List<Article> ListOfArticles
        {
            get { return listOfArticles; }
            set { listOfArticles = value; }
        }

        public void AddArticles(params Article[] articlesList)
        {
            listOfArticles.AddRange(articlesList);
        }
        public Magazine(string magazineTitle, Person.Frequency releaseFrequency, System.DateTime releaseDate, int edition)
        {
            MagazineTitle = magazineTitle;
            ReleaseFrequency = releaseFrequency;
            ReleaseDate = releaseDate;
            Edition = edition;
        }
        public override string ToString()
        {
            return $"Title of a Magazine: {MagazineTitle},\n" +
                $"Frequaency of releases: {ReleaseFrequency},\n" +
                $"Date of release: {ReleaseDate},\n" +
                $"Edition: {Edition},\n" +
                $"Overall list of articles: {listOfArticles}";
        }

        public virtual string ToShortString()
        {
            return $"Title of a Magazine: {MagazineTitle},\n" + 
                $"Frequaency of releases: {ReleaseFrequency},\n" +
                $"Date of release: {ReleaseDate},\n" +
                $"Edition: {Edition},\n" +
                $"Average article rating: {RatingCalculation}";
        }
        public Magazine() 
        {
            MagazineTitle = "Some default title";
            ReleaseFrequency = Person.Frequency.Weekly;
            ReleaseDate = System.DateTime.Now;
            Edition = 0;
        }
        
        public double RatingCalculation
        {
            get {
                double sumRating = 0;
                if (listOfArticles != null)
                {
                    foreach (Article article in listOfArticles)
                    {
                        sumRating += article.ArticleRating;
                    }
                    return sumRating / listOfArticles.Count;
                }
                else
                {
                    return Convert.ToDouble(0);
                }
            }
                
        }

       
    }
}
