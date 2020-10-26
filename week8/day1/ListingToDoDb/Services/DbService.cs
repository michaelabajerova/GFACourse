using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingToDoDb.Database;
using ListingToDoDb.Models.ViewModels;

namespace ListingToDoDb.Services
{
    public class DbService : IToDoService
    {
        private ApplicationContext context;

        public DbService(ApplicationContext context)
        {
            this.context = context;
        }

        public List<ToDo> FirstTodo()
        {
            return context.Todos.ToList();
        }
        public void SaveToDo(ToDo todo)
        {
            context.Todos.Add(todo);
            context.SaveChanges();
        }
        public List<ToDo> ActiveTasks()
        {
            return context.Todos.Where(t => !t.IsDone).ToList();
        }
        public void AddTask(ToDo todo)
        {
            context.Todos.Add(todo);
            context.SaveChanges();
        }

    }
}
