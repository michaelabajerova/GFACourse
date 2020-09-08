using System;
using System.Text;

namespace StringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // I would like to replace "dishwasher" with "galaxy" in this example, but it has a problem.
            // Please fix it for me!
            // Expected ouput: In a galaxy far far away
            string example = "In a dishwasher far far away";

            string newExample = example.Replace("dishwasher", "galaxy");

            Console.WriteLine(newExample);

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!
            string url = "https//www.reddit.com/r/nevertellmethebots";
            string newurl = url.Replace("bots", "odds").Insert(5, ":");
            Console.WriteLine(newurl);

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            StringBuilder newQuote = new StringBuilder("Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.");
            newQuote.Insert(20, " always takes longer than");
            Console.WriteLine(newQuote);

            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo
            string todoText = " - Buy milk\n";
           
            string newToDo = todoText.Insert(0, "My todo:").Insert(19, "\n - Download games").Insert(37, " Diablo");

            Console.WriteLine(newToDo);

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!
            string toBeReversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            string reversed = "";
            int length;
            length = toBeReversed.Length - 1;

            while (length >= 0)
            {
                reversed = reversed + toBeReversed[length];
                length--;
            }
            Console.WriteLine(reversed);

            Console.ReadLine();
        }
    }
}
