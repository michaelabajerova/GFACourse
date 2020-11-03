using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingToDoDb.Models.Entities;

namespace ListingToDoDb.Models.ViewModels
{
    public class ToDo
    {     
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }
        public Assignee Assignees { get; set; }

        public ToDo(long id, string title, string description, bool isUrgent, bool isDone)
        {
            Id = id;
            Title = title;
            Description = description;
            IsUrgent = isUrgent;
            IsDone = isDone;
        }
    }
}
