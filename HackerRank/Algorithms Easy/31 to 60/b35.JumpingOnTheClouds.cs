using System;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public class JumpingOnTheClouds
    {
        public static void JumpingOnTheCloudsMethod()
        {
            Console.WriteLine("Solution:");
            Console.WriteLine(jumpingOnClouds(new int[] { 0, 0, 1, 0, 0, 1, 0 }));
        }

        static int jumpingOnClouds(int[] c)
        {
            int count = 0;

            for (int i = 0; i < c.Count() - 1; i++)
            {
                if (i + 2 <= c.Length - 1 && c[i + 2] != 1)
                {
                    i += 1;
                }

                count++;
                if (i > c.Count())
                    break;
            }
            return count;
        }
    }
}
