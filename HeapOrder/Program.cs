using System;

namespace HeapOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 2, 6, 5, 7, 8, 9, 10, 0 };
            HeapSort(arr);
            Console.WriteLine("Hello World!");
        }

        // 按照最大堆来做
        public static void DownAjust(int[] array, int parentIndex, int length)
        {
            int temp = array[parentIndex];
            int childIndex = 2 * parentIndex + 1;
            while (childIndex < length)
            {
                // 如果有右孩子，且右孩子大于左孩子的值，则定位到右孩子
                if (childIndex + 1 < length && array[childIndex + 1] > array[childIndex])
                {
                    childIndex++;
                }

                // 如果父节点大于任何一个孩子的值，则直接跳出
                if (temp >= array[childIndex])
                {
                    break;
                }

                // 无需真正交换，单向赋值即可
                array[parentIndex] = array[childIndex];
                parentIndex = childIndex;
                childIndex = 2 * childIndex + 1;
            }
            array[parentIndex] = temp;
        }

        // 堆排序 升序
        public static void HeapSort(int[] array)
        {
            for (int i = (array.Length - 2) / 2; i >= 0; i--)
            {
                DownAjust(array, i, array.Length);
            }

            // 循环删除堆顶元素，移到集合末尾
            for (int i = array.Length - 1; i > 0; i--)
            {
                // 将其与末尾元素进行交换，此时末尾就为最大值。
                int temp = array[i];
                array[i] = array[0];
                array[0] = temp;
                DownAjust(array, 0, i);
            }
        }
    }
}
