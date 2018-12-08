using System;

namespace HackerRank.Data_Structures_Easy
{
    public class TwoDArrayDS
    {
        public static void HourglassSumMethod()
        {
            int[][] arr = new int[][] { new[] {1, 1, 1, 0, 0, 0 },
                                        new[] {0, 1, 0, 0, 0, 0 },
                                        new[] {1, 1, 1, 0, 0, 0 },
                                        new[] {0, 9, 2, -4, -4, 0 },
                                        new[] {0, 0, 0, -2, 0, 0 },
                                        new[] {0, 0, -1, -2, -4, 0}
                                    };


            Console.WriteLine("2D Array - DS - Hourglass Sum ");
            Console.WriteLine(hourglassSum(arr));
        }

        static int hourglassSum(int[][] arr)
        {
            int max = 0;
            int temp = int.MinValue;

            for (int i = 0; i < 4; i++)
            {
                for (int y = 0; y < 4; y++)
                {
                    max = arr[i][y] + arr[i][y + 1] + arr[i][y + 2] + arr[i + 1][y + 1] + arr[i + 2][y] + arr[i + 2][y + 1] + arr[i + 2][y + 2];

                    temp = Math.Max(temp, max);
                }
            }
            return temp;
        }
    }
}
