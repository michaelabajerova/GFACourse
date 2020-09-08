using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {


            // - Create an integer variable named `baseNum` and assign the value `123` to it
            // - Create a function called `Doubling` that doubles it's input parameter and returns with an integer
            // - Print the result of `Doubling(baseNum)`
            public static int Doubling(int baseNum)
            {

                return baseNum * 2;
            }

            // - Create a string variable named `al` and assign the value `Green Fox` to it
            // - Create a function called `Greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Green Fox`
            // - Greet `al`
            string al = "Greenfox";
            Greet(al);
            public static void Greet(string name)
            {

                Console.WriteLine("Greetings, fellow {0} ", name);
                Console.ReadLine();
            }
            // - Create a string variable named `typo` and assign the value `Chinchill` to it
            // - Write a function called `AppendAFunc` that gets a string as an input,
            //   appends an 'a' character to its end and returns with a string
            // - Print the result of `AppendAFunc(typo)`
            string typo = "Chinchill";
            Console.WriteLine(AppendAFunc(typo));
        }
        public static string AppendAFunc(string name)
        {
            return name + "a";
        }

        // Write a function called `sum` that returns the sum of numbers from zero to the given parameter
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(Sum(input));
        public static int Sum(int par)
        {
            int sum = 0;
            for (int i = 0; i <= par; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        // - Create a function called `Factorio`
        //   that returns it's input's factorial
        public static int Factorio(int function)
 
        }


    }
}
