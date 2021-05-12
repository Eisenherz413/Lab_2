using System;
using System.Collections.Generic;
using System.Text;

namespace If_Switch
{
    class Article
    {
        public Person AuthorData { get; set; }
        public string ArticleName { get; set; }
        public double ArticleRating { get; set; }
        public Article(Person authorData, string articleName, double articleRating)
        {
            AuthorData = authorData;
            ArticleName = articleName;
            ArticleRating = articleRating;
        }
        public Article() { }
        public override string ToString()
        {
            return $"About article author:{AuthorData}," +
                $" Title of an article: {ArticleName}," +
                $" Article rating: {ArticleRating}";
        }
    }
}
