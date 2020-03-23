using System;

namespace DEV_1._3
{
    class Track : Vehicle
    {
        private ushort _maxLoadWeight;

        public Track(ushort maxLoadWeight, Engine engine, Chassis chassis, Transmission transmission, string model)
           : base(engine, chassis, transmission, model)
        {
            _maxLoadWeight=maxLoadWeight;
        }

        /// <summary>
        /// Method that displays information on the console
        /// </summary>
        public new string GetInfo()
        {
            return $"Track\nMax load weight:{_maxLoadWeight}\n{base.GetInfo()}";
        }

    }
}
