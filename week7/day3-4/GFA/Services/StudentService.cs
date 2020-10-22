using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Services
{
    public class StudentService : IStudentService
    {
        private readonly List<string> names;

        public StudentService()
        {
            names = new List<string> { "Angela", "Pamela", "Sandra", "Rita", "Monica", "Erica", 
                "Tina", "Sandra", "Mary", "Jessica" };
        }

        public List<string> FindAll()
        {
            return names;
        }

        public void Save(string student)
        {
            names.Add(student);
        }
        public int Count()
        {
            return names.Count();
        }
    }
}
