using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GFA.Models
{
    public class StudentViewModel
    {
        public List<string> Students { get; set; }
        public int Count { get; set; }

        public StudentViewModel(List<string> students)
        {
            Students = students;
        }
    }
}
