using System;

namespace DEV_1._3
{
    abstract class Vehicle
    {
        private Engine _engine;
        private Chassis _chassis;
        private Transmission _transmission;
        private string _model;

        /// <summary>
        /// Constructor that initialized Vehicle class elements
        /// </summary>
        /// <param name="engine"></param>
        public Vehicle(Engine engine,Chassis chassis, Transmission transmission, string model)
        {
            _engine = engine;
            _chassis = chassis;
            _transmission = transmission;
            _model = model;

        }

        /// <summary>
        /// Method that accept and return Model values
        /// </summary>
        public string Model
        {
            get
            {
                return _model;
            }

            protected set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please write a normal string dont null or zero");
                }
                CheckLatinSymbols(value);
                _model = value;
            }

        }

        /// <summary>
        /// method accepts and returns Engine values
        /// </summary>
        public Engine Engine
        {
            get
            {
                return _engine;
            }

            set
            {
                _engine = value ?? throw new ArgumentException("");
            }
        }

        /// <summary>
        /// method Chassis accepts and returns Chassis values
        /// </summary>
        public Chassis Chassis
        {
            get
            {
                return _chassis;
            }

            set
            {
                _chassis = value ?? throw new ArgumentException("");
            }
        }

        /// <summary>
        /// method Transmission accepts and returns Transmission values
        /// </summary>
        public Transmission Transmission
        {
            get
            {
                return _transmission;
            }

            set
            {
                _transmission = value ?? throw new ArgumentException("");
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
        public string GetInfo()
        {
            return $"Model:{Model}\n\n{Transmission.GetInfo()}\n{Chassis.GetInfo()}\n{Engine.GetInfo()}";
        }


    }
}
