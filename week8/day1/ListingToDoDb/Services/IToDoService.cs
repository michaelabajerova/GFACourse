using System.Collections.Generic;
using ListingToDoDb.Models.ViewModels;

namespace ListingToDoDb.Services
{
    public interface IToDoService
    {
        public List<ToDo> FirstTodo();
        public List<ToDo> ActiveTasks();
        public void AddTask(ToDo todo);
    }
}