using System;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public class TheHurdleRace
    {
        public static void HurdleRace()
        {
            Console.WriteLine("Solution.");
            Console.WriteLine(hurdleRace(4, new int[] { 1, 6, 3, 5, 2 }));
        }
        static int hurdleRace(int k, int[] height)
        {
            return height.Max() > k ? height.Max() - k : 0;
        }
    }
}
