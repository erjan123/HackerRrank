using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public class CutTheSticks
    {
        public static void CutTheSticksMethod()
        {
            int[] array = new int[] { 1, 2, 3, 4, 3, 3, 2, 1 };
            Console.WriteLine("Solution:");
            cutTheSticks(array).ToList().ForEach(x => Console.WriteLine(x));
        }

        static int[] cutTheSticks(int[] arr)
        {
            var stickList = arr.ToList();
            var results = new List<int>();

            int minStick = stickList.Min();

            int count = 0;
            bool loop = true;

            while (loop)
            {
                for (int i = 0; i < stickList.Count; i++)
                {
                    if (stickList[i] > 0)
                    {
                        stickList[i] = stickList[i] - minStick;
                        count++;
                        if (stickList[i] < 0)
                            stickList[i] = 0;
                    }
                }

                results.Add(count);
                count = 0;

                stickList.RemoveAll(item => item == 0);

                if (stickList.Any())
                    minStick = stickList.Min();
                else
                    loop = false;
            }

            return results.ToArray();
        }
    }
}
