using System;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public class FindTheMedian
    {
        public static void FindTheMediaMethod()
        {
            Console.WriteLine("Solution:");
            Console.WriteLine(findMedian(new int[] { 0, 1, 2, 4, 6, 5, 3 }));
        }

        static int findMedian(int[] arr)
        {
            if (arr.Count() % 2 == 0)
                return 0;

            Array.Sort(arr);
            return arr[(arr.Length - 1) / 2];
        }
    }
}
