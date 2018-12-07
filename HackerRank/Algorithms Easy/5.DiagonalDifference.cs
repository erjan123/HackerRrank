using System;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public static class DiagonalDifference
    {
        public static void DiagonalDifferenceMethod()
        {
            int[][] array = { new int[] { 1, 2, 3 },
                              new int[] { 4, 5, 6 },
                              new int[] { 9, 8, 9 }
                            };

            Console.Write("Diagonal Difference with two loops : ");
            Console.WriteLine(diagonalDifference1(array));

            Console.Write("Diagonal Difference with one loop : ");
            Console.WriteLine(diagonalDifference2(array));
        }
        private static int diagonalDifference1(int[][] a)
        {
            int diaglonal1 = 0;
            int diaglonal2 = 0;

            int arrayCount = a.Count();

            for (int i = 0; i < a.Count(); i++)
            {
                diaglonal1 += a[i][i];
            }

            int temp = 0;
            for (int y = a.Count() - 1; y >= 0; y--)
            {
                diaglonal2 += a[temp][y];
                temp++;
            }

            return Math.Abs(diaglonal1 - diaglonal2);

        }

        private static int diagonalDifference2(int[][] a)
        {
            int sum = 0;
            int j = a.Length - 1;
            for (int i = 0; i < a.Count(); i++)
            {
                sum  += a[i][i] - a[j][i];
                j--;
            }

            return Math.Abs(sum);
        }

    }
}
