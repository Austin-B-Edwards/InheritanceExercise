using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
   public class Reptile : Animal
    {
        public Reptile()
        {
            Legs = 4;
            Color = "Brown";
        }
        public bool ColdBlooded { get; set; }
        public bool HasScales { get; set; }
        public string EyeShape { get; set; }
        public int Length { get; set; }
    }

}

