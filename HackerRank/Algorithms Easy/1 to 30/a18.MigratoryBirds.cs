using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public class MigratoryBirds
    {
        public static void MigratoryBirdsMethod()
        {
            Console.WriteLine("Solution with two For Loops.");
            Console.WriteLine(migratoryBirds(new List<int> { 1, 4, 4, 4, 5, 3 }));

            Console.WriteLine("\r\nSolution with Linq.");
            Console.WriteLine(migratoryBirds2(new List<int> { 1, 4, 4, 4, 5, 3 }));
        }

        static int migratoryBirds(List<int> arr)
        {
            var birdsCount = new Dictionary<int,int>();
            var maxMatch = new Dictionary<int,int>();

            foreach(var i in arr)
            {
                if(!birdsCount.ContainsKey(i))
                    birdsCount.Add(i, 1);
                else
                    birdsCount[i] = birdsCount[i] + 1;
            }

            int max = birdsCount.Values.Max();

            foreach(var i in birdsCount)
            {
                if(i.Value == max)
                {
                    maxMatch.Add(i.Key, i.Value);
                }        
            }  
            return maxMatch.Keys.Min();   
        }

        static int migratoryBirds2(List<int> arr)
        {
            return arr.GroupBy(a => a)
                    .Select(b => new {
                                        Bird = b.Key,
                                        Count = b.Count() })
                   .OrderByDescending(c => c.Count)
                   .ThenBy(d => d.Bird)
                   .FirstOrDefault()
                   .Bird;
        }
    }
}
