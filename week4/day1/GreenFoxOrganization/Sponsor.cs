using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Sponsor : Person
    {
        public string Company { get; set; }
        public int HiredStudents { get; set; }

        public Sponsor(string name, int age, string gender, string comp) : base(name, age, gender)
        {
          Company = comp;
          HiredStudents = 0;
        }
        public Sponsor() : base()
        {
            Company = "Google";
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} who represents {Company} and hired {HiredStudents} students so far.");
        }
        public void Hire()
        {
            HiredStudents++;
        }
        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
    }
}
