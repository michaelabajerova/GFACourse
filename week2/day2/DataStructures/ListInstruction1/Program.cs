using System;
using System.Collections.Generic;

namespace ListInstruction1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("William");
            names.Add("John");
            names.Add("Amanda");
/*
            Console.WriteLine(names.Count);
            Console.WriteLine(names[2]);

            foreach (string i in names)
            {
                Console.WriteLine(i);
            }*/
            names.RemoveAt(1);
            foreach (string a in names)
            {
                Console.WriteLine(a);

            }
           

            Console.ReadLine();
        }
    }
}
