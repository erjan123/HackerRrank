using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public class BreakingTheRecords
    {
        public static void BreakingTheRecordsMethod()
        {
            var scores = new[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

            Console.WriteLine("Solution");
            breakingRecords(scores).ToList().ForEach(result => Console.Write(result + " "));
        }
        static int[] breakingRecords(int[] scores)
        {
            int[] records = new int[2] { 0, 0 };
            int max = scores[0];
            int min = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (max < scores[i])
                {
                    records[0]++;
                    max = scores[i];
                }
                if (min > scores[i])
                {
                    records[1]++;
                    min = scores[i];
                }
            }
            return records;
        }
    }
}
