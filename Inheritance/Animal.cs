using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Inheritance
{
   public class Animal
    {
        public Animal()
        {
            
            HasClaws = true;
           
            HasTail = true;
        }

        public int Legs { get; set; }
        public bool HasTail { get; set; }
        public bool HasClaws { get; set; }
        public string Color { get; set; }

    }
}
