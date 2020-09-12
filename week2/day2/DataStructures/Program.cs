using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // list instruction //
            List<string> names = new List<string>();
            names.Add("William");
            names.Add("John");
            names.Add("Amanda");

            Console.WriteLine(names.Count);
            Console.WriteLine(names[2]);

            foreach (string i in names)
            {
                Console.WriteLine(i);
            }
            names.RemoveAt(1);
            foreach (string a in names)
            {
                Console.WriteLine(a);
            }
            // list instruction 2 //
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
            foreach (var listBB in ListB)
            {
                Console.WriteLine(listBB);
            }
            // map introduction //
            Dictionary<int, char> mapOfSoul = new Dictionary<int, char>();
            mapOfSoul.Add(97, 'a');
            mapOfSoul.Add(98, 'b');
            mapOfSoul.Add(99, 'c');
            mapOfSoul.Add(65, 'A');
            mapOfSoul.Add(66, 'B');
            mapOfSoul.Add(67, 'C');

            foreach (var key in mapOfSoul.Keys)
            {
                Console.WriteLine("{0}", key);
            }
            foreach (var value in mapOfSoul.Values)
            {
                Console.WriteLine(value);
            }
            mapOfSoul.Add(68, 'D');
            foreach (var total in mapOfSoul)
            {
                Console.WriteLine(total);
            }

            int b = mapOfSoul.Count;
            Console.WriteLine(b);


            if (mapOfSoul.ContainsKey(99))
            {
                Console.WriteLine(mapOfSoul[99]);
            }

            mapOfSoul.Remove(97);
            foreach (var edited in mapOfSoul)
            {
                Console.WriteLine(edited);
            }

            if (mapOfSoul.ContainsKey(100))
            {
                Console.WriteLine(mapOfSoul[100]);
            }
            else
            {
                Console.WriteLine("doesnt exists");
            }
            mapOfSoul.Clear();
            // map introduction 2 //
            Dictionary<string, string> mapIntro = new Dictionary<string, string>();
            mapIntro.Add("978-1-60309-452-8", "A Letter to Jo");
            mapIntro.Add("978-1-60309-459-7", "Lupus");
            mapIntro.Add("978-1-60309-444-3", "Red Panda and Moon Bear");
            mapIntro.Add("978-1-60309-461-0", "The Lab");

            mapIntro.Remove("978-1-60309-444-3");
            mapIntro.Remove("978-1-60309-461-0");

            foreach (var finish in mapIntro)
            {
                Console.WriteLine(finish);
            }

            mapIntro.Add("978-1-60309-450-4", "They Called Us Enemy");
            mapIntro.Add("978-1-60309-453-5", "Why Did We Trust Him?");

            if (mapIntro.ContainsKey("478-0-61159-424-8"))
            {
                Console.WriteLine("nothing");
            }
            if (mapIntro.ContainsKey("978-1-60309-453-5"))
            {
                Console.WriteLine(mapIntro["978-1-60309-453-5"]);
            }
            Sweets();
            PutSaturn();
        }

        private static void Sweets()
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            list.Remove(2);
            list.Remove(false);

            list.Insert(1, "Croissant");
            list.Insert(3, "Ice cream");

            foreach (string sweets in list)
            {
                Console.WriteLine(sweets);
                Console.ReadLine();
            }
        }

        private static void PutSaturn()
        {
            List<string> planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };
            planetList.Insert(5, "Saturn");

            foreach (string planets in planetList)
            {
                Console.Write(planets);
                Console.ReadLine();
            }
        }
    }
}
