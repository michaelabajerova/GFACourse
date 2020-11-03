using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ListingToDoDb.Models.ViewModels;

namespace ListingToDoDb.Models.Entities
{
    public class Assignee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<ToDo> AssignedTodos { get; set; }
    }
}
