using System;

namespace HackerRank.Algorithms_Easy
{
    public class ElectronicsShop
    {
        public static void GetMoneySpent()
        {
            Console.WriteLine("Solution - Test 1");
            Console.WriteLine(getMoneySpent(new int[] {3, 1 }, new int[] { 5, 2, 8 }, 10));

            Console.WriteLine();
            Console.WriteLine("Solution - Test 2");
            Console.WriteLine(getMoneySpent(new int[] {4}, new int[] { 5 }, 5));

        }
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int maxToSpent = 0;

            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int y = 0; y < drives.Length; y++)
                {
                    int add = keyboards[i] + drives[y];
                    if (add <= b && add > maxToSpent)
                    {
                        maxToSpent = keyboards[i] + drives[y];
                    }
                }
            }
            return maxToSpent > 0 ? maxToSpent : -1;
        }
    }
}
