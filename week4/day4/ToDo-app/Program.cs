using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace ToDo_app
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintUsage greet = new PrintUsage();
            greet.PrinUsages();

            Console.ReadLine();

            TaskList one = new TaskList();
           

            if (args.Length > 0)
            {
                switch (args[0])
                {
                    case "-l":
                        one.ListTask();
                        one.EmptyList();
                        break;
                    case "-a":
                        for (int i = 0; i < args.Length; i++)
                        {
                            one.AddTask();
                        }
                        break;
                    case "-r":
                        one.RemoveTask();
                        break;
                    /*case "-c":*/






                        /*Console.Beep(650, 300);
                        Console.Beep(650, 300);
                        Console.Beep(650, 300);
                        Console.Beep(500, 300);
                        Console.Beep(660, 300);
                        Console.Beep(780, 300);
                        Console.Beep(400, 300);
                        Console.Beep(500, 300);
                        Console.Beep(400, 300);
                        Console.Beep(330, 300);
                        Console.Beep(440, 300);
                        Console.Beep(490, 300);
                        Console.Beep(460, 300);
                        Console.Beep(440, 300);
                        Console.Beep(390, 300);
                        Console.Beep(650, 300);
                        Console.Beep(680, 300);
                        Console.Beep(700, 300);
                        Console.Beep(690, 300);
                        Console.Beep(750, 250);
                        Console.Beep(700, 250);
                        Console.Beep(600, 250);
                        Console.Beep(580, 250);
                        Console.Beep(500, 250);
                        Console.Beep(500, 250);
                        Console.Beep(400, 250);*/

                }
            }
        }
    }
}
