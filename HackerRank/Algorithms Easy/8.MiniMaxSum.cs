using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public static class MiniMaxSum
    {
        public static void MiniMaxSumMethod()
        {
            Console.WriteLine("The Minimum and Max Sum in Array - bad solution.");
            miniMaxSum(new[] { 1, 2, 3, 4, 5 });

            Console.WriteLine();
            Console.WriteLine("The Minimum and Max Sum - litle better solution");
            miniMaxSum2(new[] { 1, 2, 3, 4, 5 });

            Console.WriteLine();
            Console.WriteLine("The Minimum and Max Sum with Linq methods (SUM,MAX, MIN)");
            miniMaxSum3(new[] { 1, 2, 3, 4, 5 });
        }

        static void miniMaxSum(int[] arr)
        {
            Int64 sum = 0;
            Int64 min = 0;
            Int64 max = 0;
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            min = sum - arr[arr.Length - 1];
            max = sum - arr[0];
            Console.Write(min + " " + max);
        }

        static void miniMaxSum2(int[] arr)
        {
            Int64 sum = 0;
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.Write((sum - arr[arr.Length - 1]) + " " + (sum - arr[0]));
        }

        static void miniMaxSum3(int[] arr)
        {
            Console.WriteLine((arr.Sum() - arr.Max()) + " " + (arr.Sum() - arr.Min()));
        }
    }
}
