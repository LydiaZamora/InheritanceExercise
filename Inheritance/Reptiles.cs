using System;
namespace Inheritance
{
	public class Reptiles : Animal
    {
      
     // give this class 4 members that are specific to Reptile
     // Set this class to inherit from your Animal Class

      public bool LikeWater { get; set; }
      public bool HaveScales { get; set; }
      public string Habitat { get; set; }
      public bool HasLegs { get; set; }


        public Reptiles()
		{
		}
	}
}

