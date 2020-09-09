using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each line from the file.
            // If the program is unable to read the file (for example it does not exist),
            // then it should print the following error message: "Unable to read file: my-file.txt"

            string path = @"C:\Users\bajer\Documents\Greenfox\michaelabajerova\week2\day3\PrintEachLine\my-file.txt";
            try
            {
                using (var reader = new StreamReader(path))
                {
                    var line = reader.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
            Console.ReadLine();
        }
    }
}
