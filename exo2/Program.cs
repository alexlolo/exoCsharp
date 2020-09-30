using System;
using System.Collections.Generic;
using System.Linq;

namespace exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearsList = new List<int>()
            { 1003, 1690, 2004, 2020, 2072, 3497};

            var requete = from year in yearsList
                          where isBessextile(year)
                          select year;

            var sortList = requete.ToList();
            sortList.ForEach(y =>
            {
                Console.WriteLine(y);
            });
        }

        public static bool isBessextile(int year)
        {
            var firstDate = new DateTime(year, 1, 1);
            var endDate = new DateTime(year, 12, 31);
            TimeSpan Ts = endDate - firstDate;

            var nbJours = Ts.TotalDays + 1;
            if (nbJours == 366)
                return true;

            return false;
        }
    }
}
