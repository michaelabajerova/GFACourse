using System;

namespace Greenfox
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Arithmetic Assignments operators///
            int a = 12;
            a += 4;
            Console.WriteLine(a);
            int b = 12;
            b -= 4;
            Console.WriteLine(b);
            int c = 12;
            Console.WriteLine(c++);
            Console.WriteLine(c);
            int d = 12;
            Console.WriteLine(++d);
            Console.WriteLine(d);
            int e = 12;
            Console.WriteLine(e--);
            Console.WriteLine(e);
            int f = 12;
            Console.WriteLine(--f);
            Console.WriteLine(f);
            int g = 12;
            g *= 3;
            Console.WriteLine(g);
            int h = 12;
            h /= 3;
            Console.WriteLine(h);
            int i = 12;
            i %= 7;
            Console.WriteLine(i);

            Console.ReadLine();

            /// user input ///
            Console.WriteLine("Hello user, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);
            Console.WriteLine("How old are you?");

            string age = Console.ReadLine();
            Console.WriteLine(age + " is a nice age");

            Console.ReadLine();

            Console.WriteLine("Please select coffee size: 1=small, 2=medium, 3=large");
            string input = Console.ReadLine();
            int price = 0;

            switch (input)
            {
                case "1":
                case "small":
                    price = 5;
                    break;
                case "2":
                case "medium":
                    price = 7;
                    break;
                case "3":
                case "large":
                    price = 9;
                    break;
                default:
                    Console.Error.WriteLine("Invalid size. Please try again.");
                    return;
            }

            Console.WriteLine($"Price: ${price}");

        }
    }
}
