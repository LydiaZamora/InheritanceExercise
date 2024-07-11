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
                SpeciesType = "northern spotted owl",
                Habitat = "old growth forests",
                Diet = "voles, birds and snakes",
                Endangered = false, 
            };

                  
            

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var alligator = new Reptiles();
            alligator.HasLegs = true;
            alligator.TypeOfSkin = "Scaley";
            alligator.IsNocturnal = true;
            alligator.CanSwim = true;
            alligator.Habitat = "wetlands";
            alligator.SpeciesType = "american alligator";
            alligator.IsDangerous = true;
            alligator.Diet = "fish, small mammals, brids";


            animals.DataBase.Add(owl);
            animals.DataBase.Add(alligator);

            foreach(var animal in animals.DataBase)
            {
                Console.WriteLine($"Species: {animal.SpeciesType}");
                Console.WriteLine($"Habitat: {animal.Habitat}");
                Console.WriteLine($"Is Nocturnal: {animal.IsNocturnal}");          
                Console.WriteLine($"Diet {animal.Diet}");

            }

            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("Type 'more' if you want more information on these two aniamls");
            var userResponse = Console.ReadLine().ToLower();

            if(userResponse.Contains("more"))
            {
                Console.WriteLine("The Northern Spotted Owl");
                Console.WriteLine($"Is Migratory:{owl.IsMigratory}");
                Console.WriteLine($"Wing Span: {owl.WingSpanInches}");
                Console.WriteLine($"Colors {owl.Colors}");
                Console.WriteLine($"Is Endangered:{owl.Endangered}");

                Console.WriteLine("----------------------------------");

                Console.WriteLine("The American Alligator");
                Console.WriteLine($"Has Legs:{alligator.HasLegs}");
                Console.WriteLine($"Type of Skin:{alligator.TypeOfSkin}");
                Console.WriteLine($"Can Swim{alligator.CanSwim}");
                Console.WriteLine($"Is Dangerous:{alligator.IsDangerous}");

            }
        }
    }
}
