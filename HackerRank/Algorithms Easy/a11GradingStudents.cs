using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public class GradingStudents
    {
        public static void GradingStudentsMethod()
        {
            Console.WriteLine("Solution with Linq.");
            gradingStudents(new[] { 73, 67, 38, 33 }).ToList().ForEach(grade => Console.Write(grade + " ")); 
        }
        static int[] gradingStudents(int[] grades)
        {
            return grades.Select(grade => grade < 38 || (grade % 5 < 3) ? grade : grade + (5 - grade % 5)).ToArray();

        }
    }
}
