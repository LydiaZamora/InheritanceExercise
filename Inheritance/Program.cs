using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            var animals = new Animal();

            var owl = new Bird()
            {
                IsMigratory = false,
                IsNocturnal = true,
                WingSpanInches = 42,
                Colors = "brown and White",
                SpeciesType = "northern spotted",
                Ecosystem = "old growth forests",    
            };

            animals.DataBase.Add(owl);       
            
            owl.MakesNoise("hoot hoot");
            owl.EatsFood("eats red tree vole");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var alligator = new Reptiles();
            alligator.HasLegs = true;
            alligator.HaveScales = true;
            alligator.IsNocturnal = true;
            alligator.LikeWater = true;
            alligator.Habitat = "wetlands";
            alligator.SpeciesType = "american alligator";

            alligator.MakesNoise("grunt");
            alligator.EatsFood("eats fish");

            animals.DataBase.Add(alligator);

            foreach(var animal in animals.DataBase)
            {
                Console.WriteLine($"Type of Species: {animal.SpeciesType}");
                Console.WriteLine($"Is Nocturnal: {animal.IsNocturnal}");
            }
        }
    }
}
