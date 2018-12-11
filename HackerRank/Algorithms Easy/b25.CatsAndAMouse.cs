using System;

namespace HackerRank.Algorithms_Easy
{
    public class CatsAndAMouse
    {
        public static void CatsAndAMouseMethod()
        {
            Console.WriteLine("Solution - Test 1");
            Console.WriteLine(catAndMouse(1,2,3));

            Console.WriteLine();
            Console.WriteLine("Solution - Test 2");
            Console.WriteLine(catAndMouse(1, 3, 2));
        }
        static string catAndMouse(int x, int y, int z)
        {
            int catA = Math.Abs(z - x);
            int catB = Math.Abs(z - y);

            if (catA < catB)
            {
                return "Cat A";
            }
            else if (catA > catB)
            {
                return "Cat B";
            }
            else if (catA == catB)
            {
                return "Mouse C";
            }

            return "";
        }
    }
}
