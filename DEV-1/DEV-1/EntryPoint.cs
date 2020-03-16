using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {

            StringAnalizer stringAnalizer = new StringAnalizer();
            Console.WriteLine(stringAnalizer.NumberOfRepeatingSymbols(null));
            Console.WriteLine(stringAnalizer.NumberOfNonRepeatingSymbols(Console.ReadLine()));

        }
    }
}