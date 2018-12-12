using System;

namespace HackerRank.Algorithms_Easy
{
    public class DivisibleSumPairs
    {
        public static void DivisibleSumPairsMethod()
        {
            var array = new[] { 1, 3, 2, 6, 1, 2 };
            Console.WriteLine("Solution with two for loops. ");
            Console.WriteLine(divisibleSumPairs(array.Length, 3, array));
        }
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int result = 0;
            int temp = 1;
            for (int i = 0; i < ar.Length; i++)
            {
                for (int x = temp; x < ar.Length; x++)
                {
                    if ((ar[i] + ar[x]) % k == 0)
                        result++;
                }
                temp++;
            }
            return result;
        }
    }
}
