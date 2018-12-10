using System;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public class BetweenTwoSets
    {
        public static void GetTotalX()
        {
            Console.WriteLine("Result: ");
            Console.WriteLine(getTotalX(new[] { 2, 4 },new[] { 16, 32, 96 }));
        }
        static int getTotalX(int[] a, int[] b)
        {
            var totalXs = 0;
            var maximumA = a.Max(); 
            var minimumB = b.Min(); 
            var counter = 1;
            var multipleOfMaxA = maximumA;

            while (multipleOfMaxA <= minimumB)
            {
                var factorOfAll = true;

                foreach (var item in a) 
                {
                    if (multipleOfMaxA % item != 0)
                    {
                        factorOfAll = false;
                        break;
                    }
                }

                if (factorOfAll)
                {
                    foreach (var item in b) 
                    {
                        if (item % multipleOfMaxA != 0)
                        {
                            factorOfAll = false;
                            break;
                        }
                    }
                }

                if (factorOfAll)
                    totalXs++;

                counter++;
                multipleOfMaxA = maximumA * counter; 
            }
            return totalXs;
        }
    }
}
