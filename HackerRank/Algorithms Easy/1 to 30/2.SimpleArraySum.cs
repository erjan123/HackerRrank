using System;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public static class SimpleArraySum
    {
        public static void SimpleArraySumMethod()
        {
            Console.WriteLine("Array sum with for Loop.");
            Console.WriteLine(simpleArraySum_WithLoop(Enumerable.Range(1, 5).ToArray()));

            Console.WriteLine();
            Console.WriteLine("Array sum with Linq method.");
            Console.WriteLine(simpleArraySum(new int[] { 1, 2, 3, 4, 5 }));
   
        }

        static int simpleArraySum_WithLoop(int[] ar)
        {
            int sum = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }

            return sum;
        }

        static int simpleArraySum(int[] ar)
        {
            return ar.Sum();
        }


    }
}
