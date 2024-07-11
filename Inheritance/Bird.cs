using System;
namespace Inheritance
{
	public class Bird : Animal
	{

        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class

		public double WingSpanInches { get; set; }
		public bool Endangered { get; set; }
		public bool IsMigratory { get; set; }
		public string Colors { get; set; }


        public Bird()
		{
		}
	}
}

