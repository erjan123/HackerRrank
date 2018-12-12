using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms_Easy
{
    public class CorrectnessAndTheLoopInvariant
    {
        public static void CorrectnessAndTheLoopInvariantMethod()
        {
            Console.WriteLine("Solution:");
            insertionSort(new int[] { 7, 4, 3, 5, 6, 2 });
        }
        public static void insertionSort(int[] A)
        {
            var j = 0;
            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];
                j = i - 1;
                while (j >= 0 && value < A[j])
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = value;
            }
            Console.WriteLine(string.Join(" ", A));
        }
    }
}
