using System;

namespace DEV_1._4
{
    class Plane : IFlyable
    {
        private const uint START_SPEED = 200;
        private const double ACCELERATION_DISTANCE = 10;
        private const uint ACCELERATION = 10;
        private const uint MAX_SPEED = 1120;

        public Plane(Point coordinates)
        {
            Coordinates = coordinates;
        }

        public Point Coordinates { get; set; }

        /// <summary>
        /// Changes the current location
        /// </summary>
        /// <param name="newCoordinates">New location</param>
        public void FlyTo(Point newCoordinates)
        {
            Coordinates = newCoordinates;
        }

        /// <summary>
        /// Counts time for plane to get to argument location
        /// </summary>
        /// <param name="newCoordiates">The end location of flight</param>
        /// <returns>The flight time</returns>
        public double GetFlyTime(Point newCoordiates)
        {
            uint currentSpeed = START_SPEED;
            double flyTime = 0;
            double remainingDistance = Coordinates.GetDistance(newCoordiates);

            while (remainingDistance < ACCELERATION_DISTANCE && currentSpeed < MAX_SPEED)
            {
                flyTime += ACCELERATION_DISTANCE / currentSpeed;
                currentSpeed += ACCELERATION;
                remainingDistance -= ACCELERATION_DISTANCE;
            }

            flyTime += remainingDistance / currentSpeed;

            return flyTime;






        }

    }
}