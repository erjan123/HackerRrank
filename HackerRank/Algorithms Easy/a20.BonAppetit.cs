using System;
using System.Collections.Generic;

namespace HackerRank.Algorithms_Easy
{
    public class BonAppetit
    {
        public static void BonAppetitMethod()
        {
            Console.WriteLine("Test 1: ");
            bonAppetit(new List<int> { 3, 10, 2, 9 },1,7);

            Console.WriteLine("\r\n\r\nTest 2: ");
            bonAppetit(new List<int> { 3, 10, 2, 9 }, 1, 12);
        }

        static void bonAppetit(List<int> bill, int k, int b)
        {
            int cost = 0;

            for (int i = 0; i < bill.Count; i++)
            {
                if (i == k)
                    continue;
                else
                    cost += bill[i];
            }

            if ((cost / 2) == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b - (cost / 2));
            }

        }
    }
}
