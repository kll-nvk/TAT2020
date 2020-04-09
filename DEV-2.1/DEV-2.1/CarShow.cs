using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_2._1
{
    class CarShow
    {

        public List<Car> Cars { get; } = new List<Car>();

        public void SetListOfCars(Car car,int amount)
        {
            for(int i=0; i < amount; i++)
            {
                Cars.Add(car);
            }
        }

        public int GetCountTypes()
        {
            return Cars.Select(x => x.Brand).Distinct().Count();
        }

        public int GetCountAll()
        {
            return Cars.Count;
        }

        public double GetAveragePrice()
        {
            if (Cars.Count > 0)
            {
                return Cars.Select(x => x.Price).Average();
            }
            return 0;
        }

        public double GetAveragePriceType(string brand)
        {
            if (Cars.Any(x => x.Brand == brand))
            {
                return Cars.Where(x => x.Brand == brand).Select(x => x.Price).Average();
            }
            else
            {
                throw new ArgumentException("There is no such car in the list");
            }
        }
}
