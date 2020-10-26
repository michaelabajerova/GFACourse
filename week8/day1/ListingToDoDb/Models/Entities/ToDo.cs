using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingToDoDb.Models.ViewModels
{
    public class ToDo
    {     
        public long Id { get; set; }
        public string Title { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }
        public ToDo(long id, string title, bool isUrgent, bool isDone)
        {
            Id = id;
            Title = title;
            IsUrgent = isUrgent;
            IsDone = isDone;
        }
    }
}
