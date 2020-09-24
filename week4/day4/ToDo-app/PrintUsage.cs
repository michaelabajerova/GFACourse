using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ToDo_app
{
    class PrintUsage
    {

        public void PrintUsages()
        {
            Console.WriteLine("$ todo \n\n Command Line Todo application\n" +
                            "=============================\n" +
                            "\n" +
                            "Command line arguments:\n" +
                            "-l   Lists all the tasks\n" +
                            "-a   Adds a new task\n" +
                            "-r   Removes a task\n" +
                            "-c   Completes a task");
        }
    }
}
