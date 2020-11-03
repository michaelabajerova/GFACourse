using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingToDoDb.Database;
using ListingToDoDb.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

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
            return context.Todos.Include(p => p.Assignees).ToList();
        }
        public List<ToDo> ActiveTasks()
        {
            return context.Todos.Include(t => t.Assignees).Where(t => t.IsDone == false).ToList();
        }
        public void AddTask(ToDo todo)
        {
            context.Todos.Add(todo);
            context.SaveChanges();
        }
        public void DeleteTodo(int ID)
        {
            context.Todos.Remove(context.Todos.Where(t => t.Id == ID).SingleOrDefault());
            context.SaveChanges();
        }

        public void UpdateTodo(ToDo updatedTodo)
        {
            context.Todos.Update(updatedTodo);
            context.SaveChanges();
        }

    }
}
