using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
		public Vehicle()
		{
		}


		public string Make { get; set; } = "generic make";
		public string Model { get; set; } = "generic model";
		public string YearMade { get; set; } = "2024";

		public abstract void DriveAbstractColor();

		public virtual void DriveVirtualGasType()
		{
			Console.WriteLine($"Standard");
		}
		
			
		

	}
}

