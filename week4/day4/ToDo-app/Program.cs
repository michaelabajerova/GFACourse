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
            greet.PrintUsages();

            string input = Convert.ToString(Console.ReadLine());

            TaskList one = new TaskList();

            if (input == "-l" || input == "-a" || input == "-c" || input == "-r")
            {
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
                        case "-c":
                            one.CheckTask();
                            break;

                    }
                }
            }
            else
            {
                Console.WriteLine("Unsupported argument");
            }  
        }
    }
}
