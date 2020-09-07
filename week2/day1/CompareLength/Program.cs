using System;

namespace CompareLength
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `firstArrayOfNumbers`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `secondArrayOfNumbers`
            //   with the following content: `[4, 5]`
            // - Print "secondArrayOfNumbers is longer" if 
            //   `secondArrayOfNumbers` has more elements than
            //   `firstArrayOfNumbers`

            int[] firstArrayOfNumbers = { 1, 2, 3 };

            int[] secondArrayOfNumbers = { 4, 5 };

            if (firstArrayOfNumbers.Length < secondArrayOfNumbers.Length)
            {
                Console.WriteLine("secondArrayOfNumbers is longer");
            }
            else
            {
                Console.WriteLine("firstArrayOfNumbers is longer");
            }
            Console.ReadLine();
        }
    }
}
