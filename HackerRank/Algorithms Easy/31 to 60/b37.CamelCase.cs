using System;
using System.Text.RegularExpressions;

namespace HackerRank.Algorithms_Easy
{
    public class CamelCase
    {
        public static void CamelCaseMethod()
        {
            Console.WriteLine("Solution:");
            Console.WriteLine(camelcase("saveChangesInTheEditor"));
        }

        static int camelcase(string s)
        {
            return Regex.Split(s, @"(?<!^)(?=[A-Z])").Length;
        }
    }
}
