using System;

namespace DEV_1._4
{
    class Drone : IFlyable
    {
        private const uint MIN_SPEED = 3;
        private const uint MAX_SPEED = 120;
        private const int MAX_DISTANCE = 1000;
        private const double FLIGHT_TIME = 10f / 60;
        private const double STOP_TIME = 1f / 60;

        private byte _speed;

        public Drone(Point coordinate, byte speed)
        {
            Speed = speed;
        }
        public Point Coordinates { get; set; }

        public byte Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value > MAX_SPEED || value < MIN_SPEED)
                {
                    throw new ArgumentException("Incorrect argument value for drone speed");
                }

                _speed = value;
            }
        }

        /// <summary>
        /// Changes the location of drone
        /// </summary>
        /// <param name="newCoordinates">New location</param>
        public void FlyTo(Point newCoordinates)
        {
            if (Coordinates.GetDistance(newCoordinates) > MAX_DISTANCE)
            {
                throw new ArgumentException($"This distance is greater than {MAX_DISTANCE}");
            }

            Coordinates = newCoordinates;
        }

        /// <summary>
        /// Counts time for drone to get to argument location
        /// </summary>
        /// <param name="newCoordinates">The end location of flight</param>
        /// <returns>The flight time</returns>
        public double GetFlyTime(Point newCoordinates)
        {
            double distance = Coordinates.GetDistance(newCoordinates);

            if (distance > MAX_DISTANCE)
            {
                throw new ArgumentException($"This distance is greater than {MAX_DISTANCE}");
            }

            double flyTime = distance / _speed;

            return flyTime + flyTime / FLIGHT_TIME * STOP_TIME;


        }
    }
}
