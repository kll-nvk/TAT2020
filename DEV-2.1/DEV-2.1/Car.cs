using System;
using System.Linq;

namespace DEV_2._1
{
    class Car
    {

        public string Brand { get; }
        
        public string Model { get; }

        private double _price;

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                
            }
        }

        public Car(string brand,string model, double price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }




    }
}
