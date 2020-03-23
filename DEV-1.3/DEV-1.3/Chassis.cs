using System;

namespace DEV_1._3
{
    class Chassis
    {
        private byte _wheelsNumber;
        private string _serialNumber;
        private uint _maxLoad;

        /// <summary>
        ///  Constructor that initialized Chassis class elements 
        /// </summary>
        public Chassis(byte wheelsNumber, string serialNumber, uint maxLoad)
        {
            WheelsNumber = wheelsNumber;
            _serialNumber = serialNumber;
            _maxLoad = maxLoad;
        }

        /// <summary>
        /// Method accept and returns WheelsNumber values
        /// </summary>
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
            return $"Chassis:\nWheels Number:{WheelsNumber}\nSerial Number:{SerialNumber}\nMax load:{_maxLoad}\n";
        }



    }
}
