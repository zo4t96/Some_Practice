using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTest
{
    public class Hourglass
    {
        public static void PrintStar(int width)
        {
            if (width % 2 == 0) return;

            int tempWidth = width;
            for (int i = 1; i <= width; i++)
            {
                string stars = string.Empty;
                int spaceCount = width - Math.Abs(tempWidth);
                for (int j = 1; j <= spaceCount / 2; j++)
                {
                    stars += " ";
                }

                for (int j = 1; j <= Math.Abs(tempWidth); j++)
                {
                    stars += "*";
                }

                Console.WriteLine(stars);
                tempWidth -= 2;
                if (tempWidth == -1) tempWidth -= 2;
            }

            if (width <= 0) return;
        }
    }
}
