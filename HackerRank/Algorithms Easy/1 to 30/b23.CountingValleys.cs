using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms_Easy
{
    public class CountingValleys
    {
        public static void CountingValleysMethod()
        {
            Console.WriteLine("Solution.");
            Console.WriteLine(countingValleys(8, "UDDDUDUU"));
        }
        static int countingValleys(int n, string s)
        {
            int seaLevel = 0;
            int countValley = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'U')
                {
                    seaLevel += 1;
                }
                else
                {
                    seaLevel -= 1;
                }

                if (seaLevel == 0 && s[i] == 'U')
                    countValley++;
            }

            return countValley;
        }
    }
}
