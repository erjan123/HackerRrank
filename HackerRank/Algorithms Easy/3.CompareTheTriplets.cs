using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 

namespace HackerRank.Algorithms_Easy
{
    public static class CompareTheTriplets
    {
        public static void CompareTheTriplets1()
        {
            List<int> a = new List<int> { 17, 28, 30 };
            var b = new List<int> { 99, 16, 8 };

            var result = compareTriplets(a, b);

            Console.WriteLine("");
            result.ForEach(x => Console.WriteLine("{0} ", x));
        }

        private static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> points = new List<int> { 0, 0 };
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    points[0]++;
                }
                else if (b[i] > a[i])
                {
                    points[1]++;
                }
            }
            return points;
        }

    }
}
