using System;
using System.ComponentModel.DataAnnotations;

namespace Greenfox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, me");

            Console.WriteLine("Humpty Dumpty sat on a wall");
            Console.WriteLine("Humpty Dumpty had a great fall");
            Console.WriteLine("All the king's horses and king's men");
            Console.WriteLine("Couldn't put put Humpty together");

            Console.WriteLine("Hello Frantisek");
            Console.WriteLine("hello Ang");
            Console.WriteLine("Hello Andy");
            /// types   ///
            Console.WriteLine("Hello world");
            Console.WriteLine(42);
            Console.WriteLine(3.1415);
           
            /// integers    ///
            Console.WriteLine(2147483647);
            Console.WriteLine(-2147483648);
            
            /// number operations ///
            Console.WriteLine(2 + 2);
            Console.WriteLine(10 - 7);
            Console.WriteLine(23 * 9);
            Console.WriteLine(15 / 5);
            Console.WriteLine(60 % 13);
            Console.WriteLine(7 / 0.9);
            /// boolean ///
            ///true,false
            Console.WriteLine(true);
            Console.WriteLine(false);
            ///negation
            Console.WriteLine(!false);
            Console.WriteLine(!true);
            ///and
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);
            ///or
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);

            /// strings ///
            
            /// special char ///
            Console.WriteLine("hello");
            Console.WriteLine("don't");
            Console.WriteLine("She said, \"you deserve a treat\" ");
            /// concation   ///
            Console.WriteLine("hand" + "some");
            /// concat string with number   ///
            Console.WriteLine("my favorite number is" + 8);


            /// variables   ///

            /// string  ///
            string greeting = "hello friends";
            Console.WriteLine(greeting);
            /// boolean ///
            bool running = true;
            Console.WriteLine(running);
            /// whole number ///
            int a = 11;
            Console.WriteLine(a);
            /// floating point number ///
            double pi = 3.141592;
            Console.WriteLine(pi)
            ///declaring var ///
            int number;
            /// assign variable (define value)///
            number = 12;
            /// mutate variable (redefine value)///
            number = 23;
            Console.ReadLine();
        }
    }
}
