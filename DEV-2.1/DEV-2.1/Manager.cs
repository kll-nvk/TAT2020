using System;
using System.Linq;

namespace DEV_2._1
{
    class Manager
    {
        private CarShow carShow;

        public Manager(CarShow carShow)
        {
            this.carShow = carShow;
        }

        public void SetListOfCars()
        {
            string brand;
            string model;
            double price;
            int amount;

            while (true)
            {
                Console.WriteLine("Input brand");
                brand = Console.ReadLine();

                Console.WriteLine("Input model");
                model = Console.ReadLine();

                Console.WriteLine("Input price");
                double.TryParse(Console.ReadLine(), out price);

                Console.WriteLine("Input amount");
                int.TryParse(Console.ReadLine(), out amount);
                carShow.SetListOfCars(new Car(brand, model, price), amount);

                Console.WriteLine("More cars?Y/N");

                if (Console.ReadLine() == "N")
                {
                    Console.Clear();
                    break;
                }

            }
        }
    }
}
