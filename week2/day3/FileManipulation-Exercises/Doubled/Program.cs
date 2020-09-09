using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts the duplicated-chars.txt 
            var path7 = @"C:\Users\bajer\Documents\Greenfox\greenfox\week2\day3\Doubled\TextFile.txt";
            var text = File.ReadAllText(path7);

            var mainText = new StringBuilder(text);

            for (int i = 0; i < mainText.Length; i++)
            {
               mainText.Remove(i, 1);
            }
            Console.WriteLine(mainText);
            Console.ReadLine();


            
        }
    }
}
