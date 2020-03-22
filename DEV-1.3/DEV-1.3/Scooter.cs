using System;

namespace DEV_1._3
{
    class Scooter : Vehicle
    {
        private byte _maxSpeed;

        public Scooter(byte maxSpeed, Engine engine, Chassis chassis, Transmission transmission, string model)
           : base(engine, chassis, transmission, model)
        {
            _maxSpeed=maxSpeed;
        }

        public new string GetInfo()
        {
            return $"Scooter\nMax Speed:{_maxSpeed}\n{base.GetInfo()}";
        }


    }
}
