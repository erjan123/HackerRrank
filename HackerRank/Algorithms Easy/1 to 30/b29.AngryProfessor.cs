using System;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public class AngryProfessor
    {
        public static void AngryProfessorMethod()
        {
            Console.WriteLine("Solution.");
            Console.WriteLine(angryProfessor(3, new int[] { -1, -3, 4, 2 }));
        }
        static string angryProfessor(int k, int[] a)
        {
            int onTime = 0;

            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] <= 0)
                {
                    onTime++;
                }
            }

            return onTime >= k ? "NO" : "YES";
        }
    }
}
