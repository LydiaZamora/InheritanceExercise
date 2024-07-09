using System;
namespace Inheritance
{
	public class Animal
	{
        // Create a class Animal
        // give this class 4 members that all Animals have in common

		public bool IsNocturnal { get; set; }
		public string SpeciesType { get; set;  }

		public void MakesNoise(string animalNoise)
		{
			Console.WriteLine(animalNoise);
		}

		public void EatsFood(string foodType)
		{
			Console.WriteLine(foodType);
		}
		
        public Animal()
		{
		}
	}
}

