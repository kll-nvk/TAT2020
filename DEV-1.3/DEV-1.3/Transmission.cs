using System;

namespace DEV_1._3
{
    class Transmission
    {
        private string _type;
        private byte _gearsNumber;
        private string _manufacturer;

        public Transmission(string type, byte gearsNumber, string manufacturer)
        {
            Type = type;
            _gearsNumber = gearsNumber;
            Manufacturer = manufacturer;
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

        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }

            set
            {
                _manufacturer = value;
            }
        }

        public string GetInfo()
        {
            return $"Transmission:\nType:{Type}\nGears Number:{_gearsNumber}\nManufacter:{Manufacturer}\n";
        }



    }
}
