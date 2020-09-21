using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Cohort
    {
        protected string Name { get; set; }
        protected List<Student> students { get; set; }
        protected List<Mentor> mentors { get; set; }
        public Cohort(string name)
        {
            Name = name;
            mentors = new List<Mentor>();
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine($"The {Name} cohort has {students.Count} students and {mentors.Count} mentors.");
        }
    }
}
