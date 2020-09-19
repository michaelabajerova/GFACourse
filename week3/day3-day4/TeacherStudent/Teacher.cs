using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherStudent
{
    class Teacher
    {
        public string Teachers { get; private set; }

        public Teacher(string teacher)
        {
            Teachers = teacher;
        }

        public void answer()
        {
            Console.WriteLine($"{Teachers} teacher is answering a question");
        }

        public void teach(Student student)
        {
            student.learn();
        }
    }
}
