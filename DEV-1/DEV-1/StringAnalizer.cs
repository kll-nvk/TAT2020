using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    public class StringAnalizer
    {
        public int NumberOfRepeatingSymbols(string word)
        {
            int max = 0;
            int count = 0;

            if (!String.IsNullOrEmpty(word))
            {
                char buffer = word[0];


                foreach (char c in word)
                {
                    if (buffer == c)
                    {
                        count++;
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
                    max = count;
                }
                    return max;
            }
            else
            {
                return 0;
            }
        }

        public int NumberOfNonRepeatingSymbols(string word)
        {
            int max = 0;
            int count = 0;

            if (!String.IsNullOrEmpty(word))
            {
                char buffer = word[0];

                foreach (char c in word)
                {
                    if (buffer != c)
                    {
                        count++;
                        buffer = c;
                    }
                    else
                    {
                        count = 1;
                        buffer = c;
                    }
                }

                if (count > max)
                {
                    max = count;
                }

                return max;
            }
            else
            {
                return 0;
            }
        }
    }
}
