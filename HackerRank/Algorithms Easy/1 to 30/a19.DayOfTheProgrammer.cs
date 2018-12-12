using System;

namespace HackerRank.Algorithms_Easy
{
    public class DayOfTheProgrammer
    {
        public static void DayOfTheProgrammerMethod()
        {
            Console.WriteLine("Solution. ");
            Console.WriteLine(dayOfProgrammer(2016));
        }
        static string dayOfProgrammer(int year)
        {
            if (year == 1918)
                return "26.09.1918";

            bool leapYear = true;

            if (year % 4 != 0 || (year > 1918 && year % 100 == 0 && year % 400 != 0))
            {
                leapYear = false;
            }

            return leapYear ? "12.09." + year.ToString() : "13.09." + year.ToString();
        }
    }
}
