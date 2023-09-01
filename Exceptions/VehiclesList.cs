using Exceptions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TaskThree.Vehicles;

namespace TaskFive
{
    public class VehiclesList
    {
        [XmlArrayItem(typeof(Car))]
        [XmlArrayItem(typeof(Bus))]
        [XmlArrayItem(typeof(Lorry))]
        [XmlArrayItem(typeof(Scooter))]
        public List<Vehicle> VehiclesListObjects { get; set; }

        public void Add(Car car)
        {
            try
            {
                this.CheckAddingAvailability(car);
                VehiclesListObjects.Add(car);
            }
            catch (AddException e)
            {
                Console.WriteLine($"{e.Message} ID {car.ID} already exists");
            }
        }

        private void CheckAddingAvailability(Car car)
        {
            if (VehiclesListObjects.Any(v => v.ID == car.ID))
            {
                throw new AddException("You are not able to add a car");
            }
        }

        public void ReplaceCar(Car car)
        {
            try
            {
                CheckReplacingAvailability(car);
                this.VehiclesListObjects.Remove(this.VehiclesListObjects.First(x => x.ID == car.ID));
                this.VehiclesListObjects.Add(car);
            }
            catch(UpdateAutoException e)
            {
                Console.WriteLine($"{e.Message} with this ID {car.ID}");
            }
        }

        private void CheckReplacingAvailability(Car car)
        {
            if (VehiclesListObjects.Any(v => v.ID == car.ID))
            {
                throw new UpdateAutoException("You are not able to update a car");
            }
        }

        public void RemoveCar(Car car)
        {
            try
            {
                CheckRemovingAvailability(car);
                this.VehiclesListObjects.Remove(this.VehiclesListObjects.First(x => x.ID != car.ID));
            }
            catch (RemoveAutoException e)
            {
                Console.WriteLine($"{e.Message} becauce this ID {car.ID} not exist");
            }
        }

        private void CheckRemovingAvailability(Car car)
        {
            if (VehiclesListObjects.Any(v => v.ID != car.ID))
            {
                throw new RemoveAutoException("You are not able to remove a car");
            }
        }
    }
}
