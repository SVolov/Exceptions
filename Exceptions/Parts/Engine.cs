using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TaskThree.Parts
{
    public class Engine
    {
        public int Power;
        public double Volume;
        public string Type;
        public int SerialNumber;

        public Engine(int power, double volume, string type, int serialNumber) 
        {
            Power = power;
            Volume = volume;
            Type = type;
            SerialNumber = serialNumber;
        }

        private Engine()  { } 
    }
}
