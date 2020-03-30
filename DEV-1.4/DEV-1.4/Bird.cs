using System;

namespace DEV_1._4
{
    class Bird:IFlyable
    {
        const int MAX_SPEED = 21;

        private byte _speed;
        public Point Coordinates { get; set; }

        public Bird(Point point)
        {
            Coordinates = point;
            _speed = (byte)new Random().Next(MAX_SPEED);
        }

        /// <summary>
        /// Changes the current location of bird
        /// </summary>
        /// <param name="newLocation">New location</param>
        public void FlyTo(Point newCoordinates)
        {
            Coordinates = newCoordinates;
        }

        /// <summary>
        /// Counts time for bird to get to location
        /// </summary>
        /// <param name="newCoordinates">The end location of flight</param>
        /// <returns>flight time</returns>
        public double GetFlyTime(Point newCoordinates)
        {
            if (_speed == 0)
            {
                throw new Exception("Bird can't reach this location, because speed equal zero")
            }

            return Coordinates.GetDistance(newCoordinates) / _speed;
        }



    }
}
