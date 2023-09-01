using Exceptions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TaskThree.Parts;

namespace TaskThree.Vehicles
{
    public class Car : Vehicle
    {
        private double timeTo100;

        public double TimeTo100
        {
            get { return timeTo100; }
            set
            {
                if (value <= 0)
                {
                    throw new InitializationException("Your time to 100 km/h is negative");
                }
                timeTo100 = value;
            }
        }

        private Car(Engine engine, Chassis chassis, Transmission transmission, double timeTo100, int id) : base(engine, chassis, transmission, id)
        {
            TimeTo100 = timeTo100;
        }

        private Car() { }

        public override void PrintInfo()
        {
            Console.WriteLine("Car");
            base.PrintInfo();
            Console.WriteLine($"Time To 100: {TimeTo100};");
        }

        public static Car InitCar(Engine engine, Chassis chassis, Transmission transmission, double timeTo100, int id)
        {
            Car output;
            try
            {
                output = new Car(engine, chassis, transmission, timeTo100, id);
            }
            catch (InitializationException e)
            {
                Console.WriteLine($"{e.Message} for car with ID {id}");
                return null;
            }
            return output;
        }
    }
}