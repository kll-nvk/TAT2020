using System;

namespace DEV_1._3
{
    class Transmission
    {
        private string _type;
        private byte _gearsNumber;
        private string _manufacturer;

        /// <summary>
        /// Constructor that initialized Transmission class elements 
        /// </summary>
        public Transmission(string type, byte gearsNumber, string manufacturer)
        {
            Type = type;
            _gearsNumber = gearsNumber;
            Manufacturer = manufacturer;
        }

        /// <summary>
        /// Method accept and returns type values
        /// </summary>
        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please write a normal string");
                }
                CheckLatinSymbols(value);
                _type = value;
            }
        }

        /// <summary>
        /// Method accept and returns Manufacturer values
        /// </summary>
        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please write a normal string");
                }
                CheckLatinSymbols(value);
                _manufacturer = value;
            }
        }

        /// <summary>
        /// A method that throws an error if the characters are not Latin alphavit
        /// </summary>
        public void CheckLatinSymbols(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!(Char.IsDigit(value[i]) || value[i] >= 'A' && value[i] <= 'Z'))
                {
                    throw new Exception("Please write a symbol which Corresponds to Latin Alfovit");
                }
            }
        }

        /// <summary>
        /// Method that displays information on the console
        /// </summary>
        /// <returns>string which contains foreign pharmacy</returns>
        public string GetInfo()
        {
            return $"Transmission:\nType:{Type}\nGears Number:{_gearsNumber}\nManufacter:{Manufacturer}\n";
        }



    }
}
