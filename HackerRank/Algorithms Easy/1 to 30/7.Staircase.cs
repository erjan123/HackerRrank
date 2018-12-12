using System;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
  public static class Staircase
    {
        public static void StaircaseMethod()
        {
            Console.WriteLine("Staircase ");
            staircase(10);

            Console.WriteLine();
            Console.WriteLine("Staircase with Pad Left ");
            staircase2(10);

            Console.WriteLine();
            Console.WriteLine("Staircase with Lambda ");
            staircase3(10);

        }
        static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int l = 0; l < n - i - 1; l++)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y < i + 1; y++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
        }

        static void staircase2(int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));
        }

        static void staircase3(int n)
        {
            Enumerable.Range(0, n).ToList().ForEach(x => Console.WriteLine(new String('#', x + 1).PadLeft(n, ' ')));
        }
    }
}
