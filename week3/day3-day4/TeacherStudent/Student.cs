using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherStudent
{
    class Student
    {
        public string Name { get; private set; }

        public Student(string name)
        {
            Name = name;
        }

        public void learn()
        {
            Console.WriteLine($"{Name} is learning something new.");
        }

        public void question(Teacher teacher)
        {
            teacher.answer();
        }
    }
}
