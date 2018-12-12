using System;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public class JumpingOnTheCloudsRevisited
    {
        public static void JumpingOnClouds()
        {
            int[] cloudTypes = { 0, 0, 1, 0, 0, 1, 1, 0 };

            Console.WriteLine("Solution:");
            Console.WriteLine(jumpingOnClouds(cloudTypes,2));
        }
        static int jumpingOnClouds(int[] c, int k)
        {
            int energy = 100;

            for (int i = k; i < c.Count(); i = i + k)
            {
                if (c[i] == 1)
                {
                    energy = energy - 3; ;
                }
                else
                {
                    energy--;
                }
            }
            if (c[0] == 1)
                energy = energy - 3;
            else
                energy--;

            return energy;
        }
    }
}
