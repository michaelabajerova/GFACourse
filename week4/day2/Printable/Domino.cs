using System;
using System.Collections.Generic;
using System.Text;

namespace Printable
{
    class Domino : IPrintable
    {
        protected int OneSide { get; set; }
        protected int OtherSide { get; set; }

        public void DominoSides(int sideOne, int otherSide)
        {
            OneSide = sideOne;
            OtherSide = otherSide;
        }
        public void PrintAllFields()
        {
            Console.WriteLine($"Domino A side: {OneSide}, B side: {OtherSide}");
        }
    }
}
