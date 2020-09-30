using System;
using System.Collections.Generic;
using System.Text;

namespace exo5
{
    public class Article
    {
        public string Nom { get; set; }
        public int Qte { get; set; }
        public double Prix { get; set; }

        public Article(string nom, int qte, double prix)
        {
            Nom = nom;
            Qte = qte;
            Prix = prix;
        }
    }
}
