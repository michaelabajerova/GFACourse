using System;
using System.Collections.Generic;
using System.Text;

namespace DoableHomework
{
    class Trees
    {

        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public char Char { get; set; }

        public Trees(string name, string color, int age, char sex)
        {
            Name = name;
            Color = color;
            Age = age;
            Char = sex;
        }
    }
}
