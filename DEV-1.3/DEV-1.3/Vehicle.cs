using System;

namespace DEV_1._3
{
    abstract class Vehicle
    {
        private Engine _engine;
        private Chassis _chassis;
        private Transmission _transmission;
        private string _model;

        public Vehicle(Engine engine,Chassis chassis, Transmission transmission, string model)
        {
            _engine = engine;
            _chassis = chassis;
            _transmission = transmission;
            _model = model;

        }

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
                    throw new ArgumentException("");
                }

            }

        }

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

        public string GetInfo()
        {
            return $"Model:{Model}\n\n{Transmission.GetInfo()}\n{Chassis.GetInfo()}\n{Engine.GetInfo()}";
        }


    }
}
