using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Student : Person, ICloneable
    {
        protected string PreviousOrganization { get; set; }
        protected int SkippedDays { get; set; }
        public Student(string name, int age, string gender, string prevOrg) : base(name, age, gender)
        {
            SkippedDays = 0;
        }
        public Student() : base()
        {
            PreviousOrganization = "The School of Life";
        }
        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} from previousOrganization who skipped skippedDays days from the course already.");
        }
        public void SkipDays(int numberOfDays)
        {
            SkippedDays += numberOfDays;
        }

        public object Clone()
        {
            return new Student("John Doe", 20, "male", "BME");
        }
    }
}
