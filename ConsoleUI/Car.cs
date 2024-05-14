using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{
		public Car()
		{
		}

		public string DoorAmount { get; set; }
		

        public override void DriveAbstractColor()
        {
            Console.WriteLine($"Color=blue");
        }

        

    }
}

