using System;
using System.Collections.Generic;

namespace MapIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
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
            mapOfSoul.Add(68,'D');
            foreach (var total in mapOfSoul)
            {
                Console.WriteLine(total);
            }

            int a = mapOfSoul.Count;
            Console.WriteLine(a);
            

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

            Console.ReadLine();
        }
    }
}
