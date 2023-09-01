using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskThree.Parts;

namespace TaskThree.Vehicles
{
    public class Lorry : Vehicle
    {
        public int CargoWeight;

        public Lorry(Engine engine, Chassis chassis, Transmission transmission, int cargoWeight, int id) : base(engine, chassis, transmission, id)
        {
            CargoWeight = cargoWeight;
        }

        private Lorry() { }

        public override void PrintInfo()
        {
            Console.WriteLine("Lorry");
            base.PrintInfo();
            Console.WriteLine($"Cargo Weight: {CargoWeight};");
        }
    }
}