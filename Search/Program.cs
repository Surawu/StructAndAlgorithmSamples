using System;

namespace Search
{
    //假设按照升序排序的数组在预先未知的某个点上进行了旋转。
    //( 例如，数组[0, 1, 2, 4, 5, 6, 7] 可能变为[4, 5, 6, 7, 0, 1, 2] )。
    //搜索一个给定的目标值，如果数组中存在这个目标值，则返回它的索引，否则返回 -1 。
    //你可以假设数组中不存在重复的元素。
    //你的算法时间复杂度必须是 O(log n) 级别
    class Program
    {
        static void Main(string[] args)
        {
            Method(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 2);
            Console.WriteLine("Hello World!");
        }

        public static int Method(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;
            while (start <= end)
            {
                var mid = start + (end - start) / 2;
                if (target == nums[mid])
                {
                    return mid;
                }

                if (nums[start] <= nums[mid]) // 前半段有序
                {
                    if (target >= nums[start] && target < nums[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else // 后半段有序
                {
                    if (target > nums[mid] && target <= nums[end])
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }

            return -1;
        }
    }
}
