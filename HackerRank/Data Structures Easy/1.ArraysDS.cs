using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Data_Structures_Easy
{
    public static class ArraysDS
    {
        public static void ReverseArray()
        {
            int[] array = Enumerable.Range(1, 10).ToArray();

            Console.Write("Reverse Array : ");
            reverseArray(array).ToList().ForEach(x => Console.Write(x + " "));

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Reverse Array with Linq Reverse() method : ");
            array.Reverse().ToList().ForEach(x => Console.Write(x + " "));
        }
        static int[] reverseArray(int[] a)
        {
            int[] temp = new int[a.Count()];
            for (int i = 1; i <= a.Count(); i++)
            {
                temp[i - 1] = a[a.Count() - i];
            }
            return temp;
        }
    }
}
