using System;
using System.Collections.Generic;
using System.Linq;

namespace exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            var listArticle = new List<Article>
            {
                new Article("Article 1", new DateTime(1998, 1, 26)),
                new Article("Article 2", new DateTime(2000, 11, 16)),
                new Article("Article 3", new DateTime(250, 12, 30)),
                new Article("Article 4", new DateTime(2030, 6, 20))
            };

            var articles = (from article in listArticle
                            where article.Date <= new DateTime(2020, 9, 24)
                            select article).ToList();

            articles.ForEach(art =>
            {
                Console.WriteLine($"Nom : {art.Nom}, Date : {art.Date}");
            });
        }
    }
}
