using System;
using System.ComponentModel;
using System.Linq;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `animals`
            //   with the following content: `["koal", "pand", "zebr"]`
            // - Add all elements an `"a"` at the end

            string[] animals = { "koal", "pand", "zebr" };
            string a = "a";

            animals[0] = animals[0] + a;
            animals[1] = animals[1] + a;
            animals[2] = animals[2] + a;

            Console.WriteLine(animals[0]);



            Console.ReadLine();
        }
    }
}
