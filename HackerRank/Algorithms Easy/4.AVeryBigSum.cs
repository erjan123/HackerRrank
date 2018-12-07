using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public static class AVeryBigSum
    {
        public static void AVeryBigSumMethod()
        {
            var array = new long[] { 1001458909, 1004570889, 1007019111, 1003302837, 1002514638, 1006431461, 1002575010, 1007514041, 1007548981, 1004402249 };

            Console.Write("Sum of array with for loop : ");
            Console.WriteLine(aVeryBigSum1(array.Length, array));

            Console.WriteLine();
            Console.Write("Sum of array with Linq Sum() method : ");
            Console.WriteLine(aVeryBigSum2(array.Length, array));

            Console.WriteLine();
            Console.Write("Sum of array with Linq ForEach() method : ");
            Console.WriteLine(aVeryBigSum3(array.Length, array));
        }
        private static long aVeryBigSum1(int n, long[] ar)
        {
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += ar[i];
            }

            return sum;
        }

        private static long aVeryBigSum2(int n, long[] ar)
        {
            return ar.Sum();
        }

        private static long aVeryBigSum3(int n, long[] ar)
        {
            long sum = 0;
            ar.ToList().ForEach(x => sum += x);
            return sum;
        }
    }
}
