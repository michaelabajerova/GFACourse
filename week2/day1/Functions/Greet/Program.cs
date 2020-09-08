using System;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Greenfox";
            Greet(al);
            
        }
        // - Create a string variable named `al` and assign the value `Green Fox` to it
        // - Create a function called `Greet` that greets it's input parameter
        //     - Greeting is printing e.g. `Greetings dear, Green Fox`
        // - Greet `al`
        public static void Greet(string name)
        {
            
            Console.WriteLine("Greetings, fellow {0} ", name);
            Console.ReadLine();
        }
    }
}
