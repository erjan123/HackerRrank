using System;

namespace HackerRank.Algorithms_Easy
{
    public class BeautifulDaysAtTheMovies
    {
        public static void BeautifulDays()
        {
            Console.WriteLine("Solution:");
            Console.WriteLine(beautifulDays(20, 23, 6));
        }
        static int beautifulDays(int i, int j, int k)
        {
            int beautifulDays = 0;
            for (int x = i; x <= j; x++)
            {
                if ((x - reverseNumber(x)) % k == 0)
                {
                    beautifulDays++;
                }
            }
            return beautifulDays;
        }

        static int reverseNumber(int Number)
        {
            int Reverse = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            return Reverse;
        }
    }
}
