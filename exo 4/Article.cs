using System;
using System.Collections.Generic;
using System.Text;

namespace exo4
{
    public class Article
    {

        public string Nom { get; set; }
        public DateTime Date { get; set; }

        public Article(string nom, DateTime date)
        {
            Nom = nom;
            Date = date;
        }
    }
}
