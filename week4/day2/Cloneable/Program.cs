using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using GreenFoxOrganization;

namespace Cloneable
{
    class Program 
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            var john = new Student("John Doe", 20, "male", "BME");
            people.Add(john);

            Student JohnTheClone = (Student)john.Clone();
        }

    }
}
