using System;

namespace MostWater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
            Console.WriteLine("Hello World!");
        }

        public static int MaxArea(int[] height)
        {
            int i = 0, j = height.Length - 1, res = 0;
            while (i < j)
            {
                res = height[i] < height[j] ?
                Math.Max(res, (j - i) * height[i++]) :
                Math.Max(res, (j - i) * height[j--]);
            }
            return res;
        }

        /// <summary>
        /// 求最小面积就是求数组中最小值
        /// </summary>
        public static int MinArea(int[] height)
        {
            int i = 0, j = height.Length - 1, res = int.MaxValue;
            while (i < j)
            {
                if (height[i] < height[j])
                {
                    res = Math.Min(res, (j - i) * height[i]);
                    j--;
                }
                else
                {
                    res = Math.Min(res, (j - i) * height[j]);
                    i++;
                }
            }

            return res;
        }
    }
}
