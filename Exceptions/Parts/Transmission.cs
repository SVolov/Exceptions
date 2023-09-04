using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThree.Parts
{
    public class Transmission
    {
        public string Type;
        public int Gear;
        public string Manufacturer;

        public Transmission(string type, int gear, string manufacturer)
        {
            Manufacturer = manufacturer;
            Type = type;
            Gear = gear;
        }

        private Transmission() { }
    }
}