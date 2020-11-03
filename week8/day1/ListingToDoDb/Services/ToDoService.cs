using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingToDoDb.Models.ViewModels;

namespace ListingToDoDb.Services
{
    public class ToDoService : IToDoService
    {
        public List<ToDo> FirstTodo()
        {
            var firstTodo = new List<ToDo> {
            new ToDo(1, "Start the day","blah", false, false),
            new ToDo(2, "Finish H2 workshop 1","blah", false, false),
            new ToDo(3, "Finish JPA workshop 2","blah", false, false),
            new ToDo(4, "Create a CRUD project","blah", false, false)
            };
            return firstTodo;
        }
        public List<ToDo> ActiveTasks()
        {
            throw new NotImplementedException();
        }

        public void AddTask(ToDo todo)
        {
            throw new NotImplementedException();
        }
    }
}
