using System;
using System.Collections.Generic;
namespace Inheritance
{
	public class Animal
	{
        // Create a class Animal
        // give this class 4 members that all Animals have in common

		public bool IsNocturnal { get; set; }
		public string SpeciesType { get; set;  }
		public string Diet { get; set; }
		public string Habitat { get; set; }


		public List<Animal> DataBase = new List<Animal>();

        public Animal()
		{
		}
	}
}

