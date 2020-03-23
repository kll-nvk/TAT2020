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


        /// <summary>
        /// Method that displays information on the console
        /// </summary>
        public new string GetInfo()
        {
            return $"Bus\nSeats Number:{_seatsNumber}\n{base.GetInfo()}";
        }



    }
}
