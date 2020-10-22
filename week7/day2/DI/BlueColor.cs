using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI
{
    public class BlueColor : IColor
    {
        public void PrintColor()
        {
            Console.WriteLine("It is blue in color...");
        }
    }
}
