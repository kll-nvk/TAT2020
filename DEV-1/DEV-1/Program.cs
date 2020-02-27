using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char buffer;
            if (word == "" || word == null)
            {
                Console.WriteLine("Empty string");
                return;
            }
            else
            {
                buffer = word[0];
                word.Remove(0, 1);
            }

            int count = 1;
            int max = 1;
            foreach (char c in word)
            {
                if (buffer == c)
                {
                    ++count;
                }
                else
                {
                    if (max < count)
                    {
                        max = count;
                    }
                    count = 1;
                    buffer = c;
                }
            }
            if (count > max)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine(max);
            }
            Console.ReadKey();
        }
    }
}