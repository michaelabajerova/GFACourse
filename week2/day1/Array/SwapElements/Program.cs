using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `orders`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `orders`

            string[] orders = { "first", "second", "third" };
            string temp;
            temp = orders[0];
            orders[0] = orders[2];
            orders[2] = temp;

            Console.WriteLine(orders[2]);
            Console.ReadLine();
        }
    }
}
