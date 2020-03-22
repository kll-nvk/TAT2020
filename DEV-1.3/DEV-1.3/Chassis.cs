using System;

namespace DEV_1._3
{
    class Chassis
    {
        private byte _wheelsNumber;
        private string _serialNumber;
        private uint _maxLoad;

        public Chassis(byte wheelsNumber, string serialNumber, uint maxLoad)
        {
            WheelsNumber = wheelsNumber;
            _serialNumber = serialNumber;
            _maxLoad = maxLoad;
        }

        public byte WheelsNumber
        {
            
            get
            {
                return _wheelsNumber;
            }

            set
            {
                if(value < 2)
                {
                    throw new ArgumentException();
                }

                _wheelsNumber = value;
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
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("");
                }
                _serialNumber = value;
            }
        }


        public string GetInfo()
        {
            return $"Chassis:\nWheels Number:{WheelsNumber}\nSerial Number:{SerialNumber}\nMax load:{_maxLoad}\n";
        }



    }
}
