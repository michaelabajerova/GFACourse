using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Counter
{
    class Counter
    {
        public int Number { get; set; }
        public int n = 0;
        public void Add(int number)
        {
            Number += number;
        }
        public void Add()
        {
            Number++;
        }
        public void Get()
        {
            Number.ToString();
        }
        public void Reset()
        {
            Number = n;
        }
    }
}
