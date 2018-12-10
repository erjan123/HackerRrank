using System;

namespace HackerRank.Algorithms_Easy
{
    public class Kangaroo
    {
        public static void KangarooMethod()
        {
            Console.WriteLine("Solution. ");
            Console.WriteLine(kangaroo(0, 3, 4, 2));
        }
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            var possible = string.Empty;
            if (x1 < x2 && v1 < v2)
            {
                possible = "NO";
            }
            else if (x2 < x1 && v2 < v1)
            {
                possible = "NO";
            }
            else if (x2 < x1)
            {
                //v2 > v1
                var numberOfJumps = ((double)(x1 - x2)) / (v2 - v1);

                if (numberOfJumps % 1 == 0)
                    possible = "YES";
                else
                    possible = "NO";
            }
            else
            {
                var numberOfJumps = ((double)(x2 - x1)) / (v1 - v2);

                if (numberOfJumps % 1 == 0)
                    possible = "YES";
                else
                    possible = "NO";
            }

            return possible;
        }
    }
}
