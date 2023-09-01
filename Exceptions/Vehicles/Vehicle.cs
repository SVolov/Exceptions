using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TaskThree.Parts;

namespace TaskThree.Vehicles
{

    public class Vehicle : IComparable<Vehicle>
    {
        public Engine Engine;
        public Chassis Chassis;
        public Transmission Transmission;
        public int ID;

        public Vehicle(Engine engine, Chassis chassis, Transmission transmission, int id)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            ID = id;
        }

        public Vehicle() { }

        public int CompareTo(Vehicle other)
        {
            int compare;
            compare = String.Compare(this.Transmission.Type, other.Transmission.Type, true);
            return compare == 0 ? -compare : compare;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Engine:");
            Console.WriteLine($"Power: {Engine.Power}; Volume: {Engine.Volume}; Type: {Engine.Type}; SerialNumber: {Engine.SerialNumber};");
            Console.WriteLine("Chassis:");
            Console.WriteLine($"Wheels: {Chassis.Wheels}; Load: {Chassis.Load}; SerialNumber: {Chassis.SerialNumber};");
            Console.WriteLine("Transmission:");
            Console.WriteLine($"Gear: {Transmission.Gear}; Type: {Transmission.Type}; Manufacturer: {Transmission.Manufacturer};");
        }
    }
}
