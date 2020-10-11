using System;

namespace Rotate
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[3][];
            a[0] = new int[] { 1, 2, 3 };
            a[1] = new int[] { 4, 5, 6 };
            a[2] = new int[] { 7, 8, 9 };
            Method(a);
            Console.WriteLine("Hello World!");
        }

        private static void Method(int[][] matrix)
        {
            // 旋转矩阵
            for (int i = 0; i < matrix.Length; i++)
            {
                int temp;
                for (int j = i; j < matrix.Length; j++)
                {
                    // 交换元素
                    temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            // 旋转每行元素
            for (int i = 0; i < matrix.Length; i++)
            {
                /*
                    [
                    [1,2],
                    [3,4]
                    ]

                    =>
                    [
                    [1,3],
                    [2,4]
                    ]
                    */

                // 如果遍历的上限是 matrix.Length，则会将旋转后的元素复原了
                int temp;
                for (int j = 0; j < matrix.Length / 2; j++)
                {
                    temp = matrix[i][j];
                    // 注意是 matrix.Length - j - 1
                    matrix[i][j] = matrix[i][matrix.Length - j - 1];
                    matrix[i][matrix.Length - j - 1] = temp;
                }
            }
        }
    }
}
