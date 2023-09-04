using System.Collections.Generic;
using System.Linq;
using TaskThree.Parts;
using TaskThree.Vehicles;
using System.Xml.Linq;
using System.Xml.Serialization;
using System;
using TaskFive;
using System.Reflection.Metadata;
using Exceptions.Exceptions;
using Exceptions;

class Program
{
    static void Main(string[] args)
    {
        Engine enginerCar = new Engine(126, 2.5, "Petrol", 123456);
        Chassis chassisCar = new Chassis(4, 654321, 2);
        Transmission transmissionCar = new Transmission("AUTO", 7, "GERMANY");

        Engine enginerCar1 = new Engine(101, 1.4, "Petrol", 483756);
        Chassis chassisCar1 = new Chassis(4, 123098, 2);
        Transmission transmissionCar1 = new Transmission("MANUAL", 5, "JAPAN");

        //call InitializationException
        Car testInitializationExceptionCar = Car.InitCar(enginerCar, chassisCar, transmissionCar, -1, 3);

        var vehicles = new VehiclesList();
        vehicles.VehiclesListObjects = new List<Vehicle>()
        {
            Car.InitCar(enginerCar, chassisCar, transmissionCar, 8, 1),
            Car.InitCar(enginerCar1, chassisCar1, transmissionCar1, 9, 2)
        };

        //call AddException
        Car testAddExceptionCar = Car.InitCar(enginerCar, chassisCar, transmissionCar, 8, 1);
        vehicles.Add(testAddExceptionCar);

        XMLHelper.SerializeToXml(vehicles, "vechicles.xml");

        //Call GetAutoByParameterException
        XMLHelper.GetAutoByParameter("numberOfSits", "5");

        //Call UpdateAutoException
        Car testUpdateAutoExceptionCar = Car.InitCar(enginerCar, chassisCar, transmissionCar, 5, 1);
        vehicles.ReplaceCar(testUpdateAutoExceptionCar);

        //Call RemoveAutoExceptoin
        Car testRemoveAutoExceptionCar = Car.InitCar(enginerCar, chassisCar, transmissionCar, 5, 4);
        vehicles.RemoveCar(testRemoveAutoExceptionCar);
    }
}

