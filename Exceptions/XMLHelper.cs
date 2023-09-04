using Exceptions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using TaskThree.Parts;
using TaskThree.Vehicles;

namespace TaskFive
{
    public class XMLHelper
    {
        public static void SerializeToXml(VehiclesList vehicles, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(VehiclesList));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, vehicles);
            }
        }

        public static List<Car> GetAutoByParameter(string parameter, string value)
        {
            var xmlStr = File.ReadAllText("vechicles.xml");
            var str = XElement.Parse(xmlStr);
            var cars = str.Elements().Elements("Car");
            var result = new List<Car>();
            try
            {
                CheckParametrExist(parameter, cars);
                var xResult = cars.Where(x => x.Descendants().Elements(parameter).Where(e => e.Value.Equals(value)).Count() > 0).ToList();
                var xmlSerializer = new XmlSerializer(typeof(Car));

                foreach (XElement el in xResult)
                {
                    result.Add((Car)xmlSerializer.Deserialize(el.CreateReader()));
                }
            }
            catch (GetAutoByParameterException e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        private static void CheckParametrExist(string parameter, IEnumerable<XElement> cars)
        {
            if (!cars.Any(x => x.Descendants().Elements(parameter).Count() > 0))
            {
                throw new GetAutoByParameterException($"No such parameter {parameter}");
            }
        }
    }
}
