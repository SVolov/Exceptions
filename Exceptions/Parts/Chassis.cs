using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThree.Parts
{
    public class Chassis
    {
        public int Wheels;
        public int SerialNumber;
        public int Load;

        public Chassis(int wheels, int serialNumber, int load)
        {
            Wheels = wheels;
            SerialNumber = serialNumber;
            Load = load;
        }

        private Chassis() { }
    }
}