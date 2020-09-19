using System;
using System.Collections.Generic;
using System.Text;

namespace PostIt
{
    class PostIt
    {
        /*        Create a PostIt a struct that has
                 a BackgroundColor
                 a Text on it
                 a TextColor
                 Create a few example post-it objects:
                 an orange with blue text: "Idea 1"
                 a pink with black text: "Awesome"
                 a yellow with green text: "Superb!"*/
        public string BackGroundColor { get; set; }
        public string Text { get; set; }
        public string TextColor { get; set; }

        public PostIt()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Idea 1");

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Awesome");

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Superb!");

            Console.ReadLine();
        }
    }
}
