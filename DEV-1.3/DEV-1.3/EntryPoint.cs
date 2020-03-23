using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {

            Bus bus = new Bus(82, new Engine(250, 5, "Diesel", "F1234"), new Chassis(12, "F1231", 2500), new Transmission("Auto", 4, "Audi"), "Ikarus");
            Console.WriteLine(bus.GetInfo());

            Car car= new Car("Sedan", new Engine(125, 1.6, "Petrol", "F324"), new Chassis(4, "A342", 500), new Transmission("Mechanical", 5, "Audi"), "Audi A6");
            Console.WriteLine(car.GetInfo());

        }
    }
}
