using System;
namespace Inheritance
{
	public class Reptiles : Animal
    {
      
     // give this class 4 members that are specific to Reptile
     // Set this class to inherit from your Animal Class

      public bool CanSwim { get; set; }
      public string TypeOfSkin { get; set; }
      public bool IsDangerous { get; set; }
      public bool HasLegs { get; set; }


        public Reptiles()
		{
		}
	}
}

