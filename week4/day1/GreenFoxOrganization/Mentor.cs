using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Mentor : Person
    {
        public string Level { get; set; }
        public Mentor(string name, int age, string gender, string lvl) : base(name, age, gender)
        {
            Level = lvl;
        }
        public Mentor() : base()
        {
            Level = "Intermediate";
        }
        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} level mentor.");
        }
    }
}
