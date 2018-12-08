using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public static class CompareTheTriplets
    {
        public static void CompareTheTripletsMethod()
        {
            List<int> a = new List<int> { 17, 28, 30 };
            var b = new List<int> { 99, 16, 8 };

            var result = compareTriplets(a, b);

            Console.WriteLine("Compare two Lists with for Loop.");
            result.ForEach(x => Console.WriteLine("{0} ", x));


            var result2 = compareTriplets2(a, b);

            Console.WriteLine("Compare two Lists with Linq");
            result.ForEach(x => Console.WriteLine("{0} ", x));
        }

        static List<int> compareTriplets(List<int> a, List<int> b)
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

        static List<int> compareTriplets2(List<int> a, List<int> b)
        {

            int num1 = 0;
            int num2 = 0;
            var result = a.Select((value, index) => new int[] {
                                                                (value > b[index]) ? num1++ : num1,
                                                                (value < b[index]) ? num2++ : num2 });

           
            return result.First().ToList();
        }

    }
}
