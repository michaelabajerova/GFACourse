using System;
using System.Collections.Generic;
using System.Text;

namespace Printable
{
    class ToDo : IPrintable
    {
        protected string Task { get; set; }
        protected string Priority { get; set; }
        protected bool IsDone { get; set; }

        public void ToDos(string task, string priority, bool isDone)
        {
            Task = Task;
            Priority = Priority;
            IsDone = isDone;
        }
        public void PrintAllFields()
        {
            Console.WriteLine($"Task: {Task} | Priority: {Priority} | Done: {IsDone}");
        }
    }
}
