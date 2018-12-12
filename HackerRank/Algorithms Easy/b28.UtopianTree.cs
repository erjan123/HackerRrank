using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms_Easy
{
    public class UtopianTree
    {
        public static void UtopianTreeMethod()
        {
            Console.WriteLine("Three different test results (with For Loop). ");
            Console.WriteLine(utopianTree(0));
            Console.WriteLine(utopianTree(1));
            Console.WriteLine(utopianTree(4));
        }
        static int utopianTree(int n)
        {
            int treeHeight = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    treeHeight = treeHeight + 1;
                }
                else
                {
                    treeHeight = 2 * treeHeight;
                }
            }
            return treeHeight;
        }
    }
}
