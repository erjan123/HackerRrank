using System;

namespace HackerRank.Algorithms_Easy
{
    public static class TimeConversion
    {
        public static void TimeConversionMethod()
        {
            Console.WriteLine("Time Conversion:");
            Console.WriteLine(timeConversion("07:05:45PM"));
        }
        static string timeConversion(string s)
        {
            return DateTime.Parse(s).ToString("HH:mm:ss");
        }
    }
}
