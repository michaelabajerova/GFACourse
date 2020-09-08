using System;

namespace SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `numbers`

            int[] numbers = { 3, 4, 5, 6, 7 };

            int total = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4];

            Console.Write(total);
            Console.ReadLine();
        } 
    }
}
