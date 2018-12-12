using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms_Easy
{
    public class DrawingBook
    {
        public static void PageCount()
        {
            Console.WriteLine("Solution.");
            Console.WriteLine(pageCount(5, 4));

            Console.WriteLine();
            Console.WriteLine("Solution (slightligh better).");
            Console.WriteLine(pageCount2(5, 4));

        }

        static int pageCount(int n, int p)
        {
            int total = n / 2;
            int right = p / 2;
            int left = total - right;
            if (right < left)
            {
                return right;
            }
            else
            {
                return left;
            }
        }

        static int pageCount2(int n, int p)
        {
            int total = n / 2;
            int right = p / 2;
            int left = total - right;
   
            return (right < left)? right : left;
        }
    }
}
