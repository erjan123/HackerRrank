using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Data_Structures_Easy
{
    public static class LeftRotation
    {
        public static void LeftRotationMethod()
        {
            Console.WriteLine("Left Rotation ");
            leftRotation(4, new[] {1,2,3,4,5 });

        }
        static void leftRotation(int d, int[] a)
        {
            int[] temp = new int[a.Length];
            int y = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if ((i + d) < a.Length)
                {
                    temp[i] = a[i + d];
                }
                else
                {
                    temp[i] = a[y++];
                }
                Console.Write(temp[i] + " ");
            }
        }
    }
}
