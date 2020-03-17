using System;
using System.Text;

namespace DEV_1._2
{
    class NumberConverter
    {

      public string ConvertNumber(int number, int numberSystem)
      {
            int residual;
            StringBuilder inverseNumber = new StringBuilder();

            while (number>0)
            {
                residual = number % numberSystem;
                number /= numberSystem;
                inverseNumber.Insert(0,residual.ToString());
            }

            return inverseNumber.ToString();
      }


    }
}
