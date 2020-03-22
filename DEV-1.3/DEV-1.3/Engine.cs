using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._3
{
    class Engine
    {
        private double _capacity;
        private string _type;
        private string _serialNumber;

        public uint Power { get; private set; }

        public Engine(uint power, double capacity, string type, string serialNumber)
        {
            Power = power;
            Capacity = capacity;
            Type = type;
            _serialNumber = serialNumber;
        }

        public double Capacity
        {
            get
            {
                return _capacity;
            }

            set
            {
                _capacity = value;
            }

        }

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }

        }

        public string SerialNumber
        {
            get
            {
                return _serialNumber;
            }

            set
            {
                _serialNumber = value;
            }

        }



        public string GetInfo()
        {

            return $"Engine:\nPower:{Power}\nCapacity:{Capacity}\nType:{Type}\nSerial Number:{SerialNumber}\n";

        }


    }
}
