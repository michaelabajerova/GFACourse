using System;
using System.Collections.Generic;

namespace ListIntroduction2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListA = new List<string> { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };
            var ListB = new List<string> { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };

            if (ListA.Contains("Durian"))
            {
                Console.WriteLine("it does");
            }
            ListB.Remove("Durian");
            ListA.Insert(3, "Kiwi");

            if (ListA.Equals(ListB))
            {
                Console.WriteLine("it is equal");
            }
            else
            {
                Console.WriteLine("it isnt equal");
            }

            var index = ListA.IndexOf("Avocado");
            var index2 = ListB.IndexOf("Durian");

            ListB.AddRange(new string[] { "Passion Fruit", "Pomelo" });

            Console.WriteLine(ListA[2]);
            foreach (var listBB in  ListB)
            {
                Console.WriteLine(listBB);
            }

            Console.ReadLine();
        }
    }
}
