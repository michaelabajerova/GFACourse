using System;
using System.Collections.Generic;
using System.Text;

namespace FleetOfThings
{
    class Thing
    {
        private string Name;
        private bool Completed;

        public Thing()
        {
        }

        public Thing(string name)
        {
            this.Name = name;
        }

        public void Complete()
        {
            this.Completed = true;
        }
        public bool Status()
        {
            return Completed;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
