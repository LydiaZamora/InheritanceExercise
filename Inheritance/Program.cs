using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             * 
             */

            var owl = new Bird()
            {
                IsMigratory = false,
                IsNocturnal = true,
                WingSpanInches = 42,
                Colors = "brown and White",
                SpeciesType = "northern spotted",
                Ecosystem = "old growth forests",    
            };

            owl.MakesNoise("hoot hoot");
            owl.EatsFood("eats red tree vole");

            Console.WriteLine("Welcome to the animal guessing game!");
            Console.WriteLine("Guess the animal based of the clues");
          


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

            
        }
    }
}
