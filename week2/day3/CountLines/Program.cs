using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
            var path = @":C\Users\bajer\Documents\Greenfox\michaelabajerova\week2\day3\CountLines\my-file.txt";
            
            try
            {
                var content = File.ReadAllText(path);
                using (StreamReader reader = new StreamReader(@":C\Users\bajer\Documents\Greenfox\michaelabajerova\week2\day3\CountLines\my-file.txt"))
                {
                    while (reader != null)
                    {
                        var count = reader.ReadToEnd();
                        Console.WriteLine(count);
                    }
                }
            }
            catch(Exception)
            {
                Console.WriteLine("0");
            }
            Console.ReadLine();


        }
    }
}
