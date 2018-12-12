using System;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public class RepeatedString
    {
        public static void RepeatedStringMethod()
        {
            Console.WriteLine("Solution:");
            Console.WriteLine(repeatedString("aba", 10));
        }
        static long repeatedString(string s, long n)
        {
            var num = n / s.Length;
            var temp = num * s.Count(x => x == 'a');
            var subTo = Convert.ToInt32(n - (num * s.Length));
            return temp + s.Substring(0, subTo).Count(x => x == 'a');
        }
    }
}
