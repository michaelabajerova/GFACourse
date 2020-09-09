using System;
using System.IO;

namespace FileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0
            try
            {
                Console.WriteLine("Enter number:");
                int number1 = int.Parse(Console.ReadLine());
                int result = 10 / number1;
                Console.WriteLine(result);
            }
            catch (Exception)
            {
                Console.WriteLine("Fail");
            }

            // Write a program that opens a file called "my-file.txt", then prints
            // each line from the file.
            // If the program is unable to read the file (for example it does not exist),
            // then it should print the following error message: "Unable to read file: my-file.txt"

            string path1 = @"C:\Users\bajer\Documents\Greenfox\michaelabajerova\week2\day3\FileManipulation\my-file.txt";
            try
            {
                using (var reader = new StreamReader(path1))
                {
                    var line = reader.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }


            // Write a function that is able to manipulate a file
            // By writing your name into it as a single line
            // The file should be named "my-file.txt"
            // In case the program is unable to write the file,
            // It should print the following error message: "Unable to write file: my-file.txt"
            var path2 = @"C:\Users\bajer\Documents\Greenfox\michaelabajerova\week2\day3\FileManipulation\my-file.txt";
            using (StreamWriter sw = new StreamWriter(path2))
            {
                sw.WriteLine("Michaela Bajerova");
            }

            using (StreamReader reader = new StreamReader(path2))
            {
                string line = string.Empty;
                while (line != null)
                {
                    Console.WriteLine(line);
                }
            }

            // Create a function that takes 3 parameters: a path, a word and a number
            // and is able to write into a file.
            // The path parameter should be a string that describes the location of the file you wish to modify
            // The word parameter should also be a string that will be written to the file as individual lines
            // The number parameter should describe how many lines the file should have.
            // If the word is 'apple' and the number is 5, it should write 5 lines
            // into the file and each line should read 'apple'
            // The function should not raise any errors if it could not write the file.

            var path3 = @"C:\Users\bajer\Documents\Greenfox\michaelabajerova\week2\day3\FileManipulation\my-file.txt";
            var word = "apple";
            var number = 5;
            using (StreamWriter sw = new StreamWriter(path3))
            {
                sw.WriteLine("apple");
                sw.WriteLine("apple");
                sw.WriteLine("apple");
                sw.WriteLine("apple");
                sw.WriteLine("apple");
            }
            using var sr = new StreamReader(path3);
            var content = sr.ReadToEnd();

            Console.WriteLine(content);

            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
            var path4 = @":C\Users\bajer\Documents\Greenfox\michaelabajerova\week2\day3\FileManipulation\my-file.txt";

            try
            {
                var content2 = File.ReadAllText(path4);
                using (StreamReader reader = new StreamReader(@":C\Users\bajer\Documents\Greenfox\michaelabajerova\week2\day3\FileManipulation\my-file.txt"))
                {
                    while (reader != null)
                    {
                        var count = reader.ReadToEnd();
                        Console.WriteLine(count);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("0");
            }
            
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful

            var path5 = @"C:\Users\bajer\Documents\Greenfox\michaelabajerova\week2\day3\FileManipulation-Practice\myfile.txt";
            var path6 = @"C:\Users\bajer\Documents\Greenfox\michaelabajerova\week2\day3\FileManipulation-Practice\myfile2.txt";

            var contentString = File.ReadAllText(path5);
            File.WriteAllText(path6, contentString);

            foreach (string line in File.ReadLines(@"C:\Users\bajer\Documents\Greenfox\michaelabajerova\week2\day3\FileManipulation-Practice\myfile2.txt"))
            {
                if (line.Contains("Hello"))
                {
                    Console.WriteLine("It does");
                }
            }
              Console.ReadLine();
        }
    }
}
