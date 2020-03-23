using System;

namespace DEV_1._3
{
    class Car : Vehicle
    {
        private string _type;

        public Car(string type, Engine engine, Chassis chassis, Transmission transmission, string model)
           : base(engine, chassis, transmission, model)
        {
            Type = type;
        }

        /// <summary>
        /// Method accept and returns Type values
        /// </summary>
        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please write a normal string dont null or zero");
                }
                CheckLatinSymbols(value);
                _type = value;
            }

        }

        /// <summary>
        /// Method that displays information on the console
        /// </summary>
        public new string GetInfo()
        {
            return $"Car\nType:{_type}\n{base.GetInfo()}";
        }



    }
}
