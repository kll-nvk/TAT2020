using System;

namespace DEV_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                NumberConverter numberConverter = new NumberConverter();
                Console.WriteLine(numberConverter.ConvertNumber(2600, 21));
            }

            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }

        }
    }
}
