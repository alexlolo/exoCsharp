﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace exoCsharp
{
    class Exo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre premier jusqu'à : ");
            var listNumber = new List<int>();
            try
            {
                listNumber = MakeArray(Int32.Parse(Console.ReadLine()));
                var listFirsts = FirstList(listNumber);
                listFirsts.ForEach(f =>
                {
                    Console.WriteLine(f);
                });
            }
            catch
            {
                Console.WriteLine("Saisie Incorrecte !!");
            }
        }

        public static List<int> MakeArray(int nb)
        {
            var listNumber = new List<int>();

            for (int i = 1; i <= nb; i++)
            {
                listNumber.Add(i);
            }

            return listNumber;
        }

        public static List<int> FirstList(List<int> list)
        {
            var firsts = (from entier in list
                          where !Premier(entier)
                          select entier).ToList();

            return firsts;
        }

        public static bool Premier(int n)
        {
            return (NombreFacteur(n) == 2);
        }

        public static int NombreFacteur(int n)
        {
            int count = 2, i;
            double racine = Math.Sqrt(n);
            for (i = 2; i <= racine; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
