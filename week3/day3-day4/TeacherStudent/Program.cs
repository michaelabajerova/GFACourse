using System;
using System.Runtime.InteropServices;

namespace TeacherStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher newTeacher = new Teacher("Programming");
            Student douchebag = new Student("Douchebag");


            newTeacher.teach(douchebag);
            douchebag.question(newTeacher);
        }
    }
}
