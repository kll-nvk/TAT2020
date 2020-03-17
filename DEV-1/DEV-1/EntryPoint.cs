using System;

namespace DEV_1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {

            StringAnalizer stringAnalizer = new StringAnalizer();
            Console.WriteLine(stringAnalizer.CountOfRepeatingSymbolsSequence("qwe"));
            Console.WriteLine(stringAnalizer.CountOfNonRepeatingSymbolsSequence("qweaaaqwe"));

        }
    }
}