using System;
using System.Text;
using System.Collections.Generic;

namespace DEV_1._2
{
    class NumberConverter
    {

        private Dictionary<int, string> _residualToNumberSystem= new Dictionary<int, string>
        {
            {0,"0"},{1,"1"},{2,"2"},{3,"3"},{4,"4"},{5,"5"},{6,"6"},{7,"7"},{8,"8"},{9,"9"},{10,"A"},
            {11,"B"},{12,"C"},{13,"D"},{14,"E"},{15,"F"},{16,"G"},{17,"H"},{18,"I"},{19,"J"},{20,"K"}
        };

        public string ConvertNumber(int number, int numberSystem)
        {

            if (numberSystem < 21 && numberSystem > 1)
            {

                int residual;
                StringBuilder inverseNumber = new StringBuilder();

                while (number > 0)
                {
                    residual = number % numberSystem;
                    number /= numberSystem;
                    inverseNumber.Insert(0, _residualToNumberSystem[residual]);
                }

                return inverseNumber.ToString();
            }

            else
            {
                throw new ArgumentException("Number System must be between 2 and 20 ");
            }

        }


    }
}
