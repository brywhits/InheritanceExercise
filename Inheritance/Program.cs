using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        { 

            var myBird = new Birds()
            {
                WingColor = "blue",
                CanFly = true,
                WillMigrate = true,
                BeakLength = 3.5,
            };

            
            var lizard = new Reptile();

            lizard.IsColdBloooded = true;
            lizard.IsScaly = true;
            lizard.Habitat = "swamp";
            lizard.CanGrowTail = true;

            var myAnimals = new Animal[] { myBird, lizard };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Alive: {animal.IsAlive}");
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"It has: {animal.LegCount}");
                Console.WriteLine($"It lives by: {animal.LandSeaAir}");
            }


        }
    }
}
