using System;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public static class PlusMinus
    {
        public static void PlusMinusMethod()
        {
            int[] array = { -4, 3, -9, 0, 4, 1 };

            Console.WriteLine("Plus Minus with for loop : ");
            plusMinus(array);

            Console.WriteLine();
            Console.WriteLine("Plus Minus with for linq : ");
            plusMinus2(array);
        }
        static void plusMinus(int[] arr)
        {
            var positive = 0;
            var negative = 0;
            var zero = 0;
            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i] > 0)
                {
                    positive++;
                }
                else if (arr[i] < 0)
                {
                    negative++;
                }
                else
                {
                    zero++;
                }
            }

            decimal temp1 = Math.Round((Decimal)positive / (Decimal)arr.Count(), 5);
            Console.WriteLine(temp1.ToString("0.00000"));

            decimal temp2 = Math.Round((Decimal)negative / (Decimal)arr.Count(), 5);
            Console.WriteLine(temp2.ToString("0.00000"));

            decimal temp3 = Math.Round((Decimal)zero / (Decimal)arr.Count(), 5);
            Console.WriteLine(temp3.ToString("0.00000"));

        }

        static void plusMinus2(int[] arr)
        {
            Console.WriteLine(((decimal)arr.Count(value => value > 0) / (decimal)arr.Length).ToString("0.00000"));
            Console.WriteLine(((decimal)arr.Count(value => value < 0) / (decimal)arr.Length).ToString("0.00000"));
            Console.WriteLine(((decimal)arr.Count(value => value == 0) / (decimal)arr.Length).ToString("0.00000"));
        }
    }
}
