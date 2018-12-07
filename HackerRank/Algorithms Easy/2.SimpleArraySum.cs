using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public static class SimpleArraySum
    {
        public static int simpleArraySum(int[] ar)
        {
            return ar.Sum();
        }

        public static int simpleArraySum_WithLoop(int[] ar)
        {
            int sum = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }

            return sum;
        }

    }
}
