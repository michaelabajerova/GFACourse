using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace GreenFoxOrganization
{
    class Person
    {
        protected string Name { get; set; }
        protected int Age {get; set;}
        protected string Gender { get; set; }

        public Person (string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public Person()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
        }
        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender}");
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment");
        }
    }
}
