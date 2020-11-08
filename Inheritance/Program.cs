

using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {



            var myBird = new Bird();
            {
                myBird.Legs = 2;
                myBird.Size = 2;
                myBird.HasFeathers = true;
            }

            var lizard = new Reptile();
            {
                lizard.HasScales = true;
                lizard.EyeShape = "Football";
                lizard.ColdBlooded = true;
                lizard.Length = 25;
            }

            var myAnimals = new Animal[] { myBird, lizard };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Has a Tail, {animal.HasTail}");
                Console.WriteLine($"Legs, {animal.Legs}");
                Console.WriteLine($"Color, {animal.Color}");
                Console.WriteLine($"");

            }

            
        }
    }
}
