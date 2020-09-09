using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that is able to manipulate a file
            // By writing your name into it as a single line
            // The file should be named "my-file.txt"
            // In case the program is unable to write the file,
            // It should print the following error message: "Unable to write file: my-file.txt"
            var path = @"C:\Users\bajer\Documents\Greenfox\michaelabajerova\week2\day3\WriteSingleLine\my-file.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Michaela Bajerova");
            }

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                Console.ReadLine();

            }
        }
    }
}
