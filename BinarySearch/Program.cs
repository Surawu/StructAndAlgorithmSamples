using System;
using System.Collections;
using System.Collections.Generic;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ns = new int[] { 5, 4, 1, 2, 4, 2 };

            var r1 = findRepeatNumber(ns);


            // 需要先排序
            int[] nums = new int[] { 5, 4, 1, 2, 3, 6 };
            QuickSort(nums, 0, nums.Length - 1);
            var r = Search(nums, 4);
            Console.WriteLine("Hello World!");
        }

        static int findRepeatNumber(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[i] != i)
                {
                    if (nums[nums[i]] == nums[i])
                        return nums[i];

                    int tmp = nums[i];
                    nums[i] = nums[tmp];
                    nums[tmp] = tmp;
                }
            }
            return -1;
        }

        private static void QuickSort(int[] nums, int s, int e)
        {
            if (s >= e)
            {
                return;
            }
            var p = Pivot(nums, s, e);
            QuickSort(nums, s, p - 1);
            QuickSort(nums, p + 1, e);
        }

        private static int Pivot(int[] nums, int s, int e)
        {
            int pivot = nums[s];
            int left = s;
            int right = e;

            while (left != right)
            {
                while (left < right && nums[right] > pivot)
                {
                    right--;
                }

                while (left < right && nums[left] <= pivot) // 这个不能丢。
                {
                    left++;
                }

                if (left < right)
                {
                    int temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                }
            }

            nums[s] = nums[left];
            nums[left] = pivot;
            return left;
        }

        // 这是简单的二分查找， 不处理  nums = [1,2,2,2,3] 这样的数组
        private static int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (right + left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
            }

            return -1;
        }
    }
}
