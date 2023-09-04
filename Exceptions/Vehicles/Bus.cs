using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskThree.Parts;

namespace TaskThree.Vehicles
{
	public class Bus : Vehicle
	{
		public int NumberOfSits;

		public Bus(Engine engine, Chassis chassis, Transmission transmission, int numberOfSits, int id) : base(engine, chassis, transmission, id)
		{
			NumberOfSits = numberOfSits;
		}

		private Bus() { }

		public override void PrintInfo()
		{
			Console.WriteLine("Bus");
			base.PrintInfo();
			Console.WriteLine($"Number Of Sits: {NumberOfSits};");
		}
	}
}
