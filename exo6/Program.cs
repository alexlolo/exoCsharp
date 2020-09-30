using System;
using System.Collections.Generic;
using System.Linq;

namespace exo6
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

            Console.Write("Saisissez le nom de l'article à afficher: ");
            var name = Console.ReadLine();

            var tuple = SearchArticle(listArticle, name);

            Console.WriteLine($"Nom: {name}, Prix: {tuple.Item2}, Quantité: {tuple.Item1}");
        }

        public static Tuple<int, double> SearchArticle(List<Article> list, string name)
        {
            var article = list.FirstOrDefault(a => a.Nom == name);
            return new Tuple<int, double>(article.Qte, article.Prix);
        }
    }
}
