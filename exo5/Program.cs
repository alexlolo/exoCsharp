using System;
using System.Collections.Generic;
using System.Linq;

namespace exo5
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

            Console.Write("Saisissez le nom de l'article à afficher : ");
            var name = Console.ReadLine();

            var article = listArticle.FirstOrDefault(a => a.Nom == name);

            if (article != null)
            {
                Console.WriteLine($"Nom: {article.Nom}, Prix: {article.Prix}, Quantité: {article.Qte}");
            }
            else
            {
                Console.WriteLine("Article non trouvé");
            }
        }
    }
}
