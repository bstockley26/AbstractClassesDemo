using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
		public Motorcycle()
		{
		}

		public string HasSidecar { get; set; }
		

        public override void DriveAbstractColor()
        {
            Console.WriteLine("Color=Blue");
        }
        public override void DriveVirtualGasType()
        {
            Console.WriteLine($"Ethanol free");
        }
    }
}

