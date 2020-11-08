using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {


        public Bird()
        {
            Speed = 30;
            WingSpan = 16;
            Size = 2;
            Legs = 2;
            Color = "Blue";
        }

        public bool HasFeathers { get; set; }
        public int WingSpan { get; set; }
        public double Speed { get; set; }
        public double Size { get; set; }
    }
}
