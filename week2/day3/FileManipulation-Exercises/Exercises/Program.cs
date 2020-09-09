using System;
using System.IO;
using System.Text;


namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts the duplicated-chars.txt 
            var path = @"C:\Users\bajer\Documents\Greenfox\michaelabajerova\week2\day3\FileManipulation-Exercises\Exercises\TextFile.txt";
            var text = File.ReadAllText(path);

            var mainText = new StringBuilder(text);

            for (int i = 0; i < mainText.Length; i++)
            {
                mainText.Remove(i, 1);
            }
            Console.WriteLine(mainText);

            // Create a method that decrypts reversed-lines.txt
            var path2 = @"C:\Users\bajer\Documents\Greenfox\michaelabajerova\week2\day3\FileManipulation-Exercises\Exercises\TextFile2.txt";
            var text2 = File.ReadAllText(path2);

            var main = new StringBuilder(text2);

            string reversed = "";
            int length;
            length = text2.Length - 1;

            while (length >= 0)
            {
                reversed = reversed + text2[length];
                length--;
            }
            Console.WriteLine(reversed);

            // Create a method that decrypts reversed-order.txt
            var path3 = @"C:\Users\bajer\Documents\Greenfox\michaelabajerova\week2\day3\FileManipulation-Exercises\Exercises\TextFile3.txt";
            var text3 = File.ReadAllText(path3);

            var mainOrder = new StringBuilder(text3);
            Console.ReadLine();
        }
    }
}
