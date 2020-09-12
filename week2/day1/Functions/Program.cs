using System;
using System.Diagnostics.CodeAnalysis;

namespace Functions
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

            // - Create an integer variable named `baseNum` and assign the value `123` to it
            // - Create a function called `Doubling` that doubles it's input parameter and returns with an integer
            // - Print the result of `Doubling(baseNum)
            Doubling();
            Greet();
            AppendFunc();
        }
        private static void Doubling()
        {
            int baseNum = 123;
            int Doubling = baseNum * 2;

            Console.WriteLine(Doubling);
        }
        // - Create a string variable named `al` and assign the value `Green Fox` to it
        // - Create a function called `Greet` that greets it's input parameter
        //     - Greeting is printing e.g. `Greetings dear, Green Fox`
        // - Greet `al`
        public static void Greet()
        {
            string al = "Green Fox";
            Console.WriteLine("Greetings dear, " + al);
            Console.ReadLine();
        }
        // - Create a string variable named `typo` and assign the value `Chinchill` to it
        // - Write a function called `AppendAFunc` that gets a string as an input,
        //   appends an 'a' character to its end and returns with a string
        // - Print the result of `AppendAFunc(typo)`
        public static void AppendFunc()
        {
            string typo = "Chinchill";
            char a = 'a';
            Console.WriteLine(typo + a);
        }
    }
}
