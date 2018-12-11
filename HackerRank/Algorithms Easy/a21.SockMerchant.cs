using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public class SockMerchant
    {
        public static void SockMerchantMethod()
        {
            var socks = new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            Console.WriteLine("Solution with for loop.");
            Console.WriteLine(sockMerchant(socks.Length, socks));

            Console.WriteLine();
            Console.WriteLine("Solution with Linq (Lambda).");
            Console.WriteLine(sockMerchant2(socks.Length, socks));

            Console.WriteLine();
            Console.WriteLine("Solution with Linq (Lambda) - (shorter solution).");
            Console.WriteLine(sockMerchant3(socks.Length, socks));
        }

        static int sockMerchant(int n, int[] ar)
        {
            var colors = new List<int>();
            int socks = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                if (colors.Contains(ar[i]))
                {
                    socks++;
                    colors.Remove(ar[i]);
                }
                else
                {
                    colors.Add(ar[i]);
                }
            }
            return socks;
        }

        static int sockMerchant2(int n, int[] ar)
        {
             return ar.GroupBy(x => x).Select(x => (x.Count() - (x.Count() % 2)) / 2).Sum(); 
        }

        static int sockMerchant3(int n, int[] ar)
        {
            return ar.GroupBy(a => a).Sum(a => a.Count() / 2);
        }
    }
}
