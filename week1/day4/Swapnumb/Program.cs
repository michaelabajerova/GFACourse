using System;

namespace Greenfox
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = 526;

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"value of variable a after swap is {a} and value of b is {b}");
        }
    }
}
