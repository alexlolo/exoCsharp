using System;
using System.Collections.Generic;

namespace exo7
{
    class Program
    {
        static void Main(string[] args)
        {
            var listArticle = new List<Article>
            {
               new Article("Article 1", 51, 100),
                new Article("Article 2", 3, 200),
                new Article("Article 3", 1, 10000),
                new Article("Article 4", 60, 5)
            };

            Console.WriteLine($"Prix Minimum = {listArticle.Min(a => a.Prix)}");
            Console.WriteLine($"Prix Maximum = {listArticle.Max(a => a.Prix)}");
            Console.WriteLine($"Prix Moyen = {listArticle.Average(a => a.Prix)}");
        }
    }
}
