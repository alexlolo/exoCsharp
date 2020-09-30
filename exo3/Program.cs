using System;
using System.Collections.Generic;
using System.Linq;

namespace exo3
{
    class Program
    {
        static void Main(string[] args)
    {
        var listNumber = new List<int>();
        Console.WriteLine("Trouver tous les entiers divisible par 5 jusqu'à:");
        try
        {
            listNumber = MakeArray(Int32.Parse(Console.ReadLine()));
            var list = listNumber.Where(x => x % 5 == 0).ToList();
            list.ForEach(x =>
            {
                Console.WriteLine(x);
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

        for (int i = 0; i <= nb; i++)
        {
            listNumber.Add(i);
        }

        return listNumber;
    }
}
}
