using System;

namespace DEV_1
{
    /// <summary>
    /// Class for string analize
    /// </summary>
    public class StringAnalizer
    {
        /// <summary>
        /// Method which count repeating symbols sequence
        /// </summary>
        /// <param name="word">String which analized</param>
        /// <returns>number of repeatin' symbols sequence</returns>
        public int CountOfRepeatingSymbolsSequence(string word)
        {
            int max = 0;
            int count = 0;

            if (!String.IsNullOrEmpty(word))
            {
                word = word.ToLower();
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

        /// <summary>
        /// Method which count non repeating symbols sequence
        /// </summary>
        /// <param name="word">String which analized</param>
        /// <returns>number of non repeating symbols sequence</returns>
        public int CountOfNonRepeatingSymbolsSequence(string word)
        {
            int max = 0;
            int count = 0;

            if (!String.IsNullOrEmpty(word))
            {
                word = word.ToLower();
                char buffer = word[0];

                foreach (char c in word)
                {
                    if (buffer != c)
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
                    }
                    buffer = c;
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
