using System;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public static class BirthdayCakeCandles
    {
        public static void BirthdayCakeCandlesMethod()
        {
            Console.WriteLine("Birthday Cake Candles - with for Loop (bad solution)");
            Console.WriteLine(birthdayCakeCandles(4, new[] { 3, 2, 1, 3 }));

            Console.WriteLine();
            Console.WriteLine("Birthday Cake Candles - with Linq.");
            Console.WriteLine(birthdayCakeCandles2(4, new[] { 3, 2, 1, 3 }));
        }
        static int birthdayCakeCandles(int n, int[] ar)
        {
            int temp = 0;
            int count = 0;

            temp = ar[0];
            count = 1;

            for (int i = 1; i < ar.Length; i++)
            {
                if (temp == ar[i])
                {
                    count++;
                }
                else if (temp < ar[i])
                {
                    temp = ar[i];
                    count = 1;
                }
            }

            return count;
        }

        static int birthdayCakeCandles2(int n, int[] ar)
        {    
            return ar.Count(x => x == ar.Max());
        }
    }
}
