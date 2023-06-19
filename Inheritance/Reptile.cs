using System;
namespace Inheritance
{
	public class Reptile : Animal
	{

		public Reptile()
		{
			IsAlive = true;
			LegCount = 4;
			LandSeaAir = "Land";
			Age = 2;
		}


		public bool IsColdBloooded { get; set; }
		public bool IsScaly { get; set; }
		public string Habitat { get; set; }
		public bool CanGrowTail { get; set; }
	}
}

