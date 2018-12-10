using System;

namespace HackerRank.Algorithms_Easy
{
    public class AppleAndOrange
    {
        public static void CountApplesAndOranges()
        {
            Console.WriteLine("Solution with for Loops.");
            countApplesAndOranges(7, 11, 5, 15, new[] { -2, 2, 1 }, new[] { 5, -6 });

        }
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int applesTotal = 0;
            int oranageTotal = 0;
            for (int i = 0; i < apples.Length; i++)
            {
                if (a + apples[i] >= s && a + apples[i] <= t)
                    applesTotal++;
            }
            for (int y = 0; y < oranges.Length; y++)
            {
                if (b + oranges[y] <= t && b + oranges[y] >= s)
                    oranageTotal++;
            }
            Console.WriteLine(applesTotal);
            Console.Write(oranageTotal);
        }
    }
}
