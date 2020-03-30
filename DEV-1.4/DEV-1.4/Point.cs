using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._4
{
    struct Point
    {
        float _coordinateX;
        float _coordinateY;
        float _coordinateZ;
        /// <summary>
        /// Constructor for Point struct
        /// </summary>
        /// <param name="x">Coordinate x value</param>
        /// <param name="y">Coordinate y value</param>
        /// <param name="z">Coordinate z value</param>
        public Point(float x,float y, float z)
        {
            if (x < 0 || y < 0 || z < 0)
            {
                throw new Exception("Coordinate less then zero");
            }

            _coordinateX = x;
            _coordinateY = y;
            _coordinateZ = z;

        }

        /// <summary>
        /// Method which calculate distanec between points
        /// </summary>
        /// <param name="point"></param>
        /// <returns>Distance between two points</returns>
        public float GetDistance(Point point)
        {
            return (float) Math.Sqrt(Math.Pow(point._coordinateX - _coordinateX, 2) +
                                      Math.Pow(point._coordinateY - _coordinateY, 2) +
                                      Math.Pow(point._coordinateZ - _coordinateZ, 2));
        }



    }
}
