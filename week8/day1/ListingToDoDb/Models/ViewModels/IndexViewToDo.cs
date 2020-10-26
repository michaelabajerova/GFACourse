using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingToDoDb.Models.ViewModels
{
    public class IndexViewToDo
    {
        public ToDo Todo { get; set; }
        public List<ToDo> Todos { get; set; }
        public IndexViewToDo()
        {
        }
        public IndexViewToDo(List<ToDo> todos)
        {
            Todos = new List<ToDo>();
            Todos = todos;
        }
        public IndexViewToDo(ToDo todo)
        {
            this.Todo = todo;
        }
    }
}
