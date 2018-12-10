using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public class BirthdayChocolate
    {
        public static void  BirthdayChocolateMethod()
        {
            List<int> bar = new List<int> { 1, 2, 1, 3, 2 };
            Console.WriteLine("Solution 1, Test 1:");
            Console.WriteLine(birthday(bar, 3, 2));

            Console.WriteLine();
            Console.WriteLine("Solution 1, Test 2:");
            Console.WriteLine(birthday(new List<int> { 1, 1, 1, 1, 1, 1 },3,2));

            Console.WriteLine();
            Console.WriteLine("Solution 2 with Linq, Test 1:");
            Console.WriteLine(birthday2(bar, 3, 2));

            Console.WriteLine();
            Console.WriteLine("Solution 2 with Linq, Test 2:");
            Console.WriteLine(birthday2(new List<int> { 1, 1, 1, 1, 1, 1 }, 3, 2));
        }

        static int birthday(List<int> s, int d, int m)
        {
            int[] sum = new int[105];
            int count = 0;
            sum[0] = 0;
            for (int i = 0; i < s.Count; i++)
            {
                sum[i + 1] = sum[i] + s[i];
            }

            for (int i = 0; i <= s.Count - m; i++)
            {
                if (sum[i + m] - sum[i] == d)
                {
                    count++;
                }
            }
            return count;
        }

        static int birthday2(List<int> s, int d, int m)
        {
            int count = 0;
            for (int i = 0; i < s.Count - (m - 1); i++)
            {
                if (s.Skip(i).Take(m).Sum() == d)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
