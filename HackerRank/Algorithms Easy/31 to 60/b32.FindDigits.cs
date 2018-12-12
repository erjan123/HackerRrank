using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public class FindDigits
    {
        public static void FindDigitsMethod()
        {
            Console.WriteLine("Solution: (Two test results)");
            Console.WriteLine(findDigits(12));
            Console.WriteLine(findDigits(1012));
        }
        static int findDigits(int n)
        {
            int[] digits = GetIntArray(n);
            int divider = 0;

            for (int i = 0; i < digits.Count(); i++)
            {
                if (digits[i] != 0)
                    if (n % digits[i] == 0)
                        divider++;
            }
            return divider;
        }

        static int[] GetIntArray(int num)
        {
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }
    }
}
