﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ToDo_app
{
    class TaskList
    {
        public void ListTask()
        {
            string path = @"C:\Users\bajer\Documents\Greenfox\michaelabajerova\week4\day4\ToDo-app\TextFile1.txt";
            string readText = File.ReadAllText(path);

            Console.WriteLine(readText);

        }
        public void EmptyList()
        {
            string path2 = @"C:\Users\bajer\Documents\Greenfox\michaelabajerova\week4\day4\ToDo-app\TextFile2.txt";
            string readText2 = File.ReadAllText(path2);

            Console.WriteLine("No todos for today! :)");
        }

        public void AddTask()
        {
            string path2 = @"C:\Users\bajer\Documents\Greenfox\michaelabajerova\week4\day4\ToDo-app\TextFile2.txt";
            string readText2 = File.ReadAllText(path2);

            File.WriteAllText(path2, "Feed the monkey");
        }
        public void RemoveTask()
        {

            string tempFile = Path.GetTempFileName();

            using (var sr = new StreamReader(@"C:\Users\bajer\Documents\Greenfox\michaelabajerova\week4\day4\ToDo-app\TextFile1.txt"))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("milk"))
                        sw.WriteLine(line);
                }
            }

            File.Delete("TextFile1.txt");
            File.Move(tempFile, "TextFile1.txt");
        }
        public void CheckTask()
        {
            string path = @"C:\Users\bajer\Documents\Greenfox\michaelabajerova\week4\day4\ToDo-app\TextFile1.txt";
            int lineNumber = 2;
            try
            {
                using (StreamReader inputFile = new StreamReader(path))
                {
                    for (int i = 1; i < lineNumber; i++)
                    {
                        inputFile.ReadLine();
                    }

                    Console.WriteLine(inputFile.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error reading the file: ");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
        public void ErrorHandling()
        {

        }
    }
}
