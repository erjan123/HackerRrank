using System;
using System.Linq;

namespace HackerRank.Algorithms_Easy
{
    public class DesignerPDFViewer
    {
        public static void DesignerPDFViewerMethod()
        {
            int[] letterHeights = { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5,5, 5,
                                    5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
            string word = "zaba";

            Console.WriteLine("Solution with linq.");
            Console.WriteLine(designerPdfViewer(letterHeights,word));
        }
        static int designerPdfViewer(int[] h, string word)
        {
            return word.Max(c => h[(int)c - 97]) * word.Length;
        }
    }
}
