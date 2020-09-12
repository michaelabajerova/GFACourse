using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            // - Change the 8 to 4
            // - Print the fourth element

            int[] numbers = { 1, 2, 3, 8, 5, 6 };
            numbers[4] = 4;

            Console.WriteLine(numbers[4]);

            // - Create a two dimensional array
            //   which can contain the different shades of specified colors
            // - In `colors[0]` store the shades of green:
            //   `"lime", "forest green", "olive", "pale green", "spring green"`
            // - In `colors[1]` store the shades of red:
            //   `"orange red", "red", "tomato"`
            // - In `colors[2]` store the shades of pink:
            //   `"orchid", "violet", "pink", "hot pink"`

            string[][] colors = new string[3][];
            colors[0] = new string[] { "lime", "forest green", "olive", "pale green", "spring green" };
            colors[1] = new string[] { "orange red", "red", "tomato" };
            colors[2] = new string[] { "orchid", "violet", "pink", "hot pink" };

            for (int i = 0; i < colors.Length; i++)
            {
                for (int j = 0; i < colors[i].Length; j++)
                {
                    Console.WriteLine(colors[i][j]);
                }
            }

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
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output

            int[,] matrix = new int[,]
            {
                   { 1, 0, 0, 0 },
                   { 0, 1, 0, 0 },
                   { 0, 0, 1, 0 },
                   { 0, 0, 0, 1 },
            };
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                    Console.Write(String.Format("{0}", matrix[row, col]));
                Console.WriteLine();
            }
            // - Create an array variable named `numList`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array

            int[] numList = { 3, 4, 5, 6, 7 };

            for (int i = 0; i <= numList.Length; i++)
            {
                numList[i] *= 2;
                Console.WriteLine(numList[i]);
            }
            //- Create an array variable named `numbers`
            //  with the following content: `[1, 2, 3, 4, 5]`
            //- Increment the third element
            //- Print the third element

            int[] numbers2 = { 1, 2, 3, 4, 5 };
            numbers[2]++;

            Console.WriteLine(numbers2[2]);

            // - Create an array variable named `numbers`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print all the elements of `numbers`

            int[] numbers3 = { 4, 5, 6, 7 };
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(numbers3[i]);
            }
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `numbers`
            // - Print the elements of the reversed `numbers`

            int[] numbers4 = { 3, 4, 5, 6, 7 };
            for (int i = numbers4.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers4[i]);
            }
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `numbers`

            int[] numbers5 = { 3, 4, 5, 6, 7 };

            int total = numbers5[0] + numbers5[1] + numbers5[2] + numbers5[3] + numbers5[4];

            Console.Write(total);
            // - Create an array variable named `numbers`
            //   with the following content: `[54, 23, 66, 12]`
            // - Print the sum of the second and the third element

            int[] numbers6 = { 54, 23, 66, 12 };

            Console.WriteLine(numbers6[1] + numbers6[2]);
            // - Create an array variable named `orders`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `orders`

            string[] orders = { "first", "second", "third" };
            string temp;
            temp = orders[0];
            orders[0] = orders[2];
            orders[2] = temp;

            Console.WriteLine(orders[2]);
            // - Create an array variable named `numbers`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print the third element of `numbers`

            int[] numbers7 = { 4, 5, 6, 7 };

            Console.WriteLine(numbers7[2]);
            Console.ReadLine();
        }
    }
}
