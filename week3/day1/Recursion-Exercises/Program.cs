using System;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Recursion_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {   // Add number //
            Console.WriteLine(numberAdder(5));
            Console.ReadLine();

            /// sum ///
            Console.WriteLine(sumDigits(12345, 0));
            Console.ReadLine();

            // Power ///
            Console.WriteLine("enter base number: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("enter exponent");
            int expoNum = int.Parse(Console.ReadLine());
            int result = power(baseNum, expoNum);

            Console.WriteLine("The value of {0} to the power of {1} is: {2} ", baseNum, expoNum, result);
            Console.ReadLine();

            /// Greatest Common Divisor ///
            Console.WriteLine("Enter first parameter: ");
            long a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second parameter: ");
            long b = int.Parse(Console.ReadLine());
            long hcf = GCD(a, b);
            Console.WriteLine(hcf);
            Console.ReadLine();

            /// Bunny ears ///
            Console.WriteLine("Enter the amount of fluffy bunnies you wish to own");
            int bunnies = int.Parse(Console.ReadLine());

            Console.WriteLine("There is: " + bunnyEars(bunnies) + " ears");
            Console.ReadLine();

            // fibonacci //
            int n = 15;
            Console.Write(Fib(n));
            Console.ReadLine();
        }

        public static long numberAdder(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n + numberAdder(n - 1);
            }
        }
        public static int sumDigits(int n, int number)
        {

            number += n % 10;
            if (n / 10 == 0)
            {
                return number;
            }
            return sumDigits(n / 10, number);
        }
        public static int power(int n, int m)
        {
            if (m == 0)
            {
                return 1;
            }
            else
            {
                return n * power(n, m - 1);
            }
        }
        public static long GCD(long a, long b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return GCD(b, a % b);
            }
        }
        public static long bunnyEars(int ears)
        {
            if (ears == 1)
            {
                return 2;
            }
            else
            {
                return 2 + bunnyEars(ears - 1);
            }

        }
        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }

    }
        

}
