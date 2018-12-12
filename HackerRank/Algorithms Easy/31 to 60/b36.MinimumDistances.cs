using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public class MinimumDistances
    {
        public static void MinimumDistancesMethod()
        {
            Console.WriteLine("Solution:");
            Console.WriteLine(minimumDistances(new int[] { 7, 1, 3, 4, 1, 7 }));        
        }

        static int minimumDistances(int[] a)
        {
            var list = new List<int>();
            list = a.ToList();
            int min = int.MaxValue;
            int index1 = new int(); 
            int index2 = default(int);

            for (int i = 0; i < list.Count; i++)
            {
                index1 = list.IndexOf(list[i]);
                index2 = list.IndexOf(list[i], list.IndexOf(list[i]) + 1);
                if (index2 == -1)
                    continue;

                if (Math.Abs(index1 - index2) < min)
                    min = Math.Abs(index1 - index2);
            }
            return min == int.MaxValue ? -1 : min;
        }
    }
}
