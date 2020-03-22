using System;

namespace DEV_1._3
{
    class Bus : Vehicle
    {
        private byte _seatsNumber;

        public Bus(byte seatsNumber, Engine engine,Chassis chassis, Transmission transmission, string model)
                   :base(engine, chassis, transmission, model)
        {
            _seatsNumber = seatsNumber;
        }

        public new string GetInfo()
        {
            return $"Bus\nSeats Number:{_seatsNumber}\n{base.GetInfo()}";
        }



    }
}
