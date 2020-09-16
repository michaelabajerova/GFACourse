using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Sharpie
{
    class Sharpie
    {
        public string Color { get; set; }
        public float Width { get; set; }
        public float InkAmount { get; set; }

        public Sharpie (string color, float width)
        {
            Color = color;
            Width = width;
            InkAmount = 100;
        }
        public void Use()
        {
            while (InkAmount <= 100)
            {
                InkAmount--;
            }

        }
    }
}
