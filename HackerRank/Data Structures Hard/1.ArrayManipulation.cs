using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Data_Structures_Hard
{
    public static class ArrayManipulation
    {
        public static void ArrayManipulationMethod()
        {
            int[][] array = { new int[] {1, 2, 100 },
                              new int[] {2, 5, 100 },
                              new int[] {3, 4, 100 }
                            };

            Console.WriteLine("Array Manipulation - the max number is: ");
            Console.WriteLine(arrayManipulation(5, array));
        }

        static long arrayManipulation(int n, int[][] queries)
        {
            long a = long.MinValue;
            long b = long.MinValue;
            long k = long.MinValue;

            long[] numList = new long[n + 1];

            for (int i = 0; i < queries.Length; i++)
            {
                a = queries[i][0];
                b = queries[i][1];
                k = queries[i][2];

                numList[a] += k;
                if (b + 1 <= n) numList[b + 1] -= k;
            }

            long tempMax = 0;
            long max = 0;
            for (int i = 1; i <= n; i++)
            {
                tempMax += numList[i];
                if (tempMax > max) max = tempMax;
            }
            return max;
        }
    }
}
