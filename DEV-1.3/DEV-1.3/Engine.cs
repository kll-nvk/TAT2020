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

        /// <summary>
        /// / <summary>
        /// Method accept and returns power values
        /// </summary>
        public uint Power { get; private set; }

        /// <summary>
        /// Constructor that initialized class elements
        /// </summary>
        public Engine(uint power, double capacity, string type, string serialNumber)
        {
            Power = power;
            Capacity = capacity;
            Type = type;
            _serialNumber = serialNumber;
        }

        /// <summary>
        /// Method accept and returns capacity values
        /// </summary>
        public double Capacity
        {
            get
            {
                return _capacity;
            }

            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Capacity must be more than zero");
                }
                _capacity = value;
            }

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
                    throw new ArgumentException("Please write correct a normal string");
                }
                CheckLatinSymbols(value);
                _type = value;
            }

        }

        /// <summary>
        /// Method accept and returns Serial number values
        /// </summary>
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
                    throw new ArgumentException("Please write correct a normal string");
                }
                CheckLatinSymbols(value);
                _serialNumber = value;
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

            return $"Engine:\nPower:{Power}\nCapacity:{Capacity}\nType:{Type}\nSerial Number:{SerialNumber}\n";

        }


    }
}
